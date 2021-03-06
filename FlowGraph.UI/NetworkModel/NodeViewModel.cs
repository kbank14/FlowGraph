﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Utils;

namespace FlowGraph.UI.NetworkModel
{
    public class NodeViewModel : AbstractModelBase
    {
        #region Private Data Members

        protected const string DefaultInputConnectorName = "Input";
        protected const string DefaultOutputConnectorName = "Output";
        public const string DefaultLeftNodeConnectorName = "Left";
        public const string DefaultRightNodeConnectorName = "Right";

        private string name = string.Empty;
        private double x = 0;
        private double y = 0;
        private int zIndex = 0;
        private Size size = Size.Empty;
        private bool isSelected = false;

        private ImpObservableCollection<ConnectorViewModel> inputConnectors = null;
        private ImpObservableCollection<ConnectorViewModel> outputConnectors = null;

        private ConnectorViewModel leftNodeConnection;
        private ConnectorViewModel rightNodeConnection;

        #endregion Private Data Members

        public NodeViewModel()
        {
            Name = name;
        }

        /// <summary>
        /// The name of the node.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { SetAndNotify(ref name, value); }
        }

        /// <summary>
        /// The X coordinate for the position of the node.
        /// </summary>
        public double X
        {
            get { return x; }
            set { SetAndNotify(ref x, value); }
        }

        /// <summary>
        /// The Y coordinate for the position of the node.
        /// </summary>
        public double Y
        {
            get { return y; }
            set { SetAndNotify(ref y, value); }
        }

        /// <summary>
        /// The Z index of the node.
        /// </summary>
        public int ZIndex
        {
            get { return zIndex; }
            set { SetAndNotify(ref zIndex, value); }
        }

        /// <summary>
        /// The size of the node.
        /// 
        /// Important Note: 
        ///     The size of a node in the UI is not determined by this property!!
        ///     Instead the size of a node in the UI is determined by the data-template for the Node class.
        ///     When the size is computed via the UI it is then pushed into the view-model
        ///     so that our application code has access to the size of a node.
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                if (SetAndNotify(ref size, value))
                {
                    SizeChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Event raised when the size of the node is changed.
        /// The size will change when the UI has determined its size based on the contents
        /// of the nodes data-template.  It then pushes the size through to the view-model
        /// and this 'SizeChanged' event occurs.
        /// </summary>
        public event EventHandler<EventArgs> SizeChanged;

        /// <summary>
        /// List of input connectors (connections points) attached to the node.
        /// </summary>
        public ImpObservableCollection<ConnectorViewModel> InputConnectors
        {
            get
            {
                if (inputConnectors == null)
                {
                    inputConnectors = new ImpObservableCollection<ConnectorViewModel>();
                    inputConnectors.ItemsAdded += new EventHandler<CollectionItemsChangedEventArgs>(InputConnectors_ItemsAdded);
                    inputConnectors.ItemsRemoved += new EventHandler<CollectionItemsChangedEventArgs>(InputConnectors_ItemsRemoved);
                }

                return inputConnectors;
            }
        }

        /// <summary>
        /// List of output connectors (connections points) attached to the node.
        /// </summary>
        public ImpObservableCollection<ConnectorViewModel> OutputConnectors
        {
            get
            {
                if (outputConnectors == null)
                {
                    outputConnectors = new ImpObservableCollection<ConnectorViewModel>();
                    outputConnectors.ItemsAdded += new EventHandler<CollectionItemsChangedEventArgs>(OutputConnectors_ItemsAdded);
                    outputConnectors.ItemsRemoved += new EventHandler<CollectionItemsChangedEventArgs>(OutputConnectors_ItemsRemoved);
                }

                return outputConnectors;
            }
        }

        /// <summary>
        /// A helper property that retrieves a list (a new list each time) of all connections attached to the node. 
        /// </summary>
        public virtual IEnumerable<AConnectionViewModel> AttachedConnections
        {
            get
            {
                var attachedConnections = new List<AConnectionViewModel>();

                foreach (var connector in this.InputConnectors)
                {
                    attachedConnections.AddRange(connector.AttachedConnections);
                }

                foreach (var connector in this.OutputConnectors)
                {
                    attachedConnections.AddRange(connector.AttachedConnections);
                }

                if(HasLeftPathConnector)
                    attachedConnections.AddRange(LeftNodeConnection.AttachedConnections);

                if(HasRightPathConnector)
                    attachedConnections.AddRange(RightNodeConnection.AttachedConnections);

                return attachedConnections;
            }
        }

        /// <summary>
        /// Set to 'true' when the node is selected.
        /// </summary>
        public bool IsSelected
        {
            get { return isSelected; }
            set { SetAndNotify(ref isSelected, value); }
        }

        public bool HasLeftPathConnector => !(LeftNodeConnection == null);

        public bool HasRightPathConnector => !(RightNodeConnection == null);

        /// <summary>
        /// The connector to the Left node of this node
        /// </summary>
        public ConnectorViewModel LeftNodeConnection
        {
            get { return leftNodeConnection; }
            set { SetAndNotify(ref leftNodeConnection, value); }
        }

        /// <summary>
        /// The connector to the Right node of this node
        /// </summary>
        public ConnectorViewModel RightNodeConnection
        {
            get { return rightNodeConnection; }
            set { SetAndNotify(ref rightNodeConnection, value); }
        }

        #region Private Methods

        /// <summary>
        /// Event raised when connectors are added to the node.
        /// </summary>
        private void InputConnectors_ItemsAdded(object sender, CollectionItemsChangedEventArgs e)
        {
            foreach (ConnectorViewModel connector in e.Items)
            {
                connector.Type = ConnectorType.Input;
                connector.ParentNode = this;
            }
        }

        /// <summary>
        /// Event raised when connectors are removed from the node.
        /// </summary>
        private void InputConnectors_ItemsRemoved(object sender, CollectionItemsChangedEventArgs e)
        {
            foreach (ConnectorViewModel connector in e.Items)
            {
                connector.Type = ConnectorType.Undefined;
                connector.ParentNode = null;
            }
        }

        /// <summary>
        /// Event raised when connectors are added to the node.
        /// </summary>
        private void OutputConnectors_ItemsAdded(object sender, CollectionItemsChangedEventArgs e)
        {
            foreach (ConnectorViewModel connector in e.Items)
            {
                connector.Type = ConnectorType.Output;
                connector.ParentNode = this;
            }
        }

        /// <summary>
        /// Event raised when connectors are removed from the node.
        /// </summary>
        private void OutputConnectors_ItemsRemoved(object sender, CollectionItemsChangedEventArgs e)
        {
            foreach (ConnectorViewModel connector in e.Items)
            {
                connector.Type = ConnectorType.Undefined;
                connector.ParentNode = null;
            }
        }

        #endregion Private Methods

        #region Public Methods

        public void AddInputConnector()
        {
            var defaultNameWithNumber = DefaultInputConnectorName + (this.InputConnectors.Count(c => c.Name == DefaultInputConnectorName) + 1);
            this.InputConnectors.Add(new ConnectorViewModel(defaultNameWithNumber));
        }

        public void AddOutputConnector()
        {
            var defaultNameWithNumber = DefaultOutputConnectorName + (this.OutputConnectors.Count(c => c.Name == DefaultOutputConnectorName) + 1);
            this.OutputConnectors.Add(new ConnectorViewModel(defaultNameWithNumber));
        }

        #endregion Public Methods
    }
}
