
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;
using Xamarin.Forms.StateSquid;

namespace SkeletonScreen
{
    public class MainPageViewModel : BaseViewModel
    {
		public State SkeletonState { get; set; }
		public ICommand SkeletonCommand { get; set; }

		public MainPageViewModel()
		{
			SkeletonCommand = new Command(async (x) =>
			{
				SkeletonState = State.Loading;
				await Task.Delay(3000);
				SkeletonState = State.None;
			});
		}
	}
}
