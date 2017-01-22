using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace XY.UI
{
    /// <summary>
    /// WindowGrid.xaml
    /// </summary>
    public partial class WindowGrid : System.Windows.Controls.UserControl
    {
        /// <summary>
        /// 
        /// </summary>
        public string Title { get; set; }
        public Window ChildWindow { get; set; }
        
        #region //ctor
        public WindowGrid()
        {
            InitializeComponent();
        }

        public WindowGrid(Window window):this()
        {
            InitFunc(window);
        } 
        #endregion

        #region //public init method
        /// <summary>
        /// public init method
        /// </summary>
        /// <param name="window"></param>
        public void Init(Window window)
        {
            InitFunc(window);
        }
        public void Init()
        {
            InitFunc(null);
        } 
        #endregion

        #region //private init method
        /// <summary>
        /// private init method
        /// </summary>
        /// <param name="window"></param>
        private void InitFunc(Window window)
        {
            if (window != null)
            {
                this.ChildWindow = window;
            }
            if (ChildWindow == null)
            {
                throw new ArgumentNullException("ChildWindow", "ChildWindow is null.");
            }
            this.ChildWindow.WindowStyle = WindowStyle.None;
            this.Name = this.ChildWindow.GetType().Name;
            this.Title = this.ChildWindow.Title;
            this.Width = ChildWindow.Width;
            this.Height = ChildWindow.Height;
            this.Content = ChildWindow.Content;
        } 
        #endregion

        #region //get ElementHost object
        /// <summary>
        /// get ElementHost object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t">Window object</param>
        /// <returns></returns>
        public static ElementHost GetHost<T>(T t=null) where T : Window, new()
        {
            Window window = new T();
            if (t!=null)
            {
                window = t;
            }
            WindowGrid wg = new WindowGrid(window);

            ElementHost host = new ElementHost
            {
                Location = new System.Drawing.Point(0, 0),
                Dock = DockStyle.Fill,
                Name = wg.Name,
                Child = wg,
                Text = window.Title
            };
            return host;
        } 
        #endregion
    }
}
