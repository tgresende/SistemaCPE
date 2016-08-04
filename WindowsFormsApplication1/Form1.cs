using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

using DevExpress.XtraEditors;

using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010.Customization;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        private System.ComponentModel.IContainer Components;

        private static DocumentManager fDocumentManager;

        public static DocumentManager DocumentManager { get { return fDocumentManager; } }

        private static WindowsUIView fMainView;

        public static WindowsUIView MainView { get { return fMainView; } }

        private static TileContainer fMainMenu;

        public static TileContainer MainMenu { get { return fMainMenu; } }

        private static Flyout fQueryGroupNameFlyout;

        public static Flyout QueryGroupNameFlyout { get { return fQueryGroupNameFlyout; } }

        public Form1() {
            InitializeComponent();

            if(Components == null) Components = new System.ComponentModel.Container();

            this.SuspendLayout();

            try {

                fDocumentManager = new DocumentManager(Components);

                ((System.ComponentModel.ISupportInitialize)(DocumentManager)).BeginInit();

                try {
                    DocumentManager.ContainerControl = this;

                    fMainView = new WindowsUIView(Components);

                    ((System.ComponentModel.ISupportInitialize)(MainView)).BeginInit();

                    try {
                        MainView.SplashScreenProperties.ShowCaption = true;
                        MainView.SplashScreenProperties.ShowLoadingDescription = true;
                        MainView.SplashScreenProperties.ShowImage = true;

                        MainView.TileContainerProperties.HeaderOffset = -10;
                        MainView.TileContainerProperties.Margin = new Padding(25);
                        MainView.TileContainerProperties.ItemSize = 160;
                        MainView.TileContainerProperties.ItemPadding = new Padding(8);

                        MainView.PageProperties.HeaderOffset = -10;
                        MainView.PageProperties.Margin = new System.Windows.Forms.Padding(0, -15, 0, 0);

                        MainView.AddTileWhenCreatingDocument = DevExpress.Utils.DefaultBoolean.False;
                        MainView.AllowCaptionDragMove = DevExpress.Utils.DefaultBoolean.True;

                        DocumentManager.ViewCollection.Add(MainView);
                        DocumentManager.View = MainView;

                        fMainMenu = new TileContainer(Components);

                        ((System.ComponentModel.ISupportInitialize)(MainMenu)).BeginInit();

                        try {
                            MainMenu.Properties.AllowDrag = DevExpress.Utils.DefaultBoolean.True;
                            MainMenu.Properties.AllowDragTilesBetweenGroups = DevExpress.Utils.DefaultBoolean.True;
                            MainMenu.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
                            MainMenu.Properties.AllowGroupHighlighting = DevExpress.Utils.DefaultBoolean.False;
                            MainMenu.Properties.AllowItemHover = DevExpress.Utils.DefaultBoolean.False;
                            MainMenu.Properties.AllowSelectedItem = DevExpress.Utils.DefaultBoolean.False;

                            MainMenu.Properties.ShowGroupText = DevExpress.Utils.DefaultBoolean.True;

                            MainMenu.Properties.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
                            MainMenu.Properties.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;

                            MainMenu.EndItemDragging += MainMenu_EndItemDragging;

                            MainView.ContentContainers.Add(MainMenu);

                            {
                                Tile Tile = new Tile();

                                Tile.Tag = null;

                                Tile.Padding = new Padding(5, 5, 5, 5);

                                Tile.Properties.ItemSize = TileItemSize.Small;
                                Tile.Properties.AllowCheck = DevExpress.Utils.DefaultBoolean.False;

                                {
                                    TileItemElement Element = new TileItemElement();

                                    Element.Text = @"Test";
                                    Element.TextAlignment = TileItemContentAlignment.BottomCenter;

                                    Tile.Elements.Add(Element);
                                }

                                MainView.Tiles.Add(Tile);

                                MainMenu.Items.Add(Tile);
                            }
                        }
                        finally {
                            ((System.ComponentModel.ISupportInitialize)(MainMenu)).EndInit();
                        }

                        {
                            Flyout Flyout = new Flyout();

                            FlyoutAction FlyoutAction = new FlyoutAction();

                            FlyoutAction.Caption = @"Enter New Group Name";

                            FlyoutAction.Commands.Add(FlyoutCommand.OK);
                            FlyoutAction.Commands.Add(FlyoutCommand.Cancel);

                            Flyout.Action = FlyoutAction;

                            fQueryGroupNameFlyout = Flyout;

                            MainView.ContentContainers.Add(Flyout);
                        }

                        MainView.ActivateContainer(MainMenu);
                    }
                    finally {
                        ((System.ComponentModel.ISupportInitialize)(MainView)).EndInit();
                    }
                }
                finally {
                    ((System.ComponentModel.ISupportInitialize)(DocumentManager)).EndInit();
                }

                QueryGroupNameFlyout.Document = MainView.AddDocument(new TextEdit()) as Document;
            }
            finally {
                this.ResumeLayout(false);

                this.PerformLayout();
            }
        }

        void MainMenu_EndItemDragging(object sender, TileItemDragEventArgs e) {
            FlyoutAction action = new FlyoutAction();
            action.Caption = "Confirm";
            //action.Commands.Add(FlyoutCommand.OK);
            //action.Commands.Add(FlyoutCommand.Cancel);
            MyFlyoutDialog dialog = new MyFlyoutDialog(this, action, new UserControl1());
            dialog.ShowDialog();
            e.Cancel = String.IsNullOrEmpty(e.TargetGroup.Text);
        }

        public class MyFlyoutDialog : FlyoutDialog {
            public MyFlyoutDialog(Form owner, FlyoutAction action, Control control)
                : base(owner, action) {
                FlyoutControl = control;
            }
        }
    }
}
