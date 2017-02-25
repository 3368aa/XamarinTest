using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace XamarinSample.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        /// <summary>
        /// 获取或设置标题
        /// 设置标题时将触发属性改变事件
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged(() => _title);
            }
        }

        private ICommand _showTitleCommand;
        private string _title;

        /// <summary>
        /// 获取 显示标题的Command
        /// </summary>
        public ICommand ShowTitleCommand
        {
            get { return _showTitleCommand ?? (_showTitleCommand = new MvxCommand(ShowTitle)); }
        }

        private void ShowTitle()
        {
            Acr.UserDialogs.UserDialogs.Instance.Alert(Title,"这是一个标题", "知道了");
        }
    }
}
