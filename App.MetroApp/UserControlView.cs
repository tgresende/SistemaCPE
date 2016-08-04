using DevExpress.Utils;
using DevExpress.Utils.Animation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App.MetroApp
{
    public class UserControlView
    {
        private Dictionary<UserControlType, XtraUserControl> _usercontrols = new Dictionary<UserControlType, XtraUserControl>();
        private TransitionManager _transiton = new TransitionManager();
        private string _ns = "";

        private XtraUserControl _usercontrolparent = null;
        public XtraUserControl UserControlParent
        {
            get { return _usercontrolparent; }
            set { _usercontrolparent = value; }
        }

        public UserControlView(string ns)
        {
            _ns = ns;

        }

        public TransitionManager CreateTransition(ITransitionAnimator animator, DefaultBoolean showprogress = DefaultBoolean.False)
        {
            Transition transition = new Transition();
            transition.TransitionType = animator;
            transition.Control = _usercontrolparent;
            transition.ShowWaitingIndicator = showprogress;

            _transiton.Transitions.Clear();
            _transiton.Transitions.Add(transition);

            return _transiton;
        }

        private void ClearUserControlParent()
        {
            if (_usercontrolparent != null)
            {
                if (_usercontrolparent.Controls.Count != 0)
                {
                    foreach (Control control in _usercontrolparent.Controls)
                        control.Parent = null;
                }
            }
        }

        public XtraUserControl GetUserControl(UserControlType type)
        {
            ClearUserControlParent();

            if (_usercontrols.Where(p => p.Key == type).Count() == 0)
            {
                _usercontrols.Add(type, (XtraUserControl)Activator.CreateInstance(Type.GetType(_ns + "." + type.ToString())));
            }

            _usercontrols.Where(p => p.Key == type).FirstOrDefault().Value.Parent = _usercontrolparent;
            _usercontrols.Where(p => p.Key == type).FirstOrDefault().Value.Dock = DockStyle.Fill;

            return _usercontrols.Where(p => p.Key == type).FirstOrDefault().Value;
        }
    }
}
