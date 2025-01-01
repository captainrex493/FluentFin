using FluentFin.Dialogs.ViewModels;
using ReactiveUI;

namespace FluentFin.Dialogs.Views;

public sealed partial class AccessSchedulePickerDialog : IViewFor<AccessSchedulePickerViewModel>
{
	public AccessSchedulePickerViewModel? ViewModel { get; set; } = App.GetService<AccessSchedulePickerViewModel>();

	object? IViewFor.ViewModel { get => ViewModel; set => ViewModel = (AccessSchedulePickerViewModel?)value; }

	public AccessSchedulePickerDialog()
	{
		InitializeComponent();
	}
}
