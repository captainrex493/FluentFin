﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentFin.Contracts.Services;
using FluentFin.Core.Contracts.Services;
using FluentFin.Core.ViewModels;
using Jellyfin.Sdk.Generated.Models;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reflection;

namespace FluentFin.ViewModels;

public partial class TitleBarViewModel : ObservableObject, ITitleBarViewModel
{
	private readonly INavigationService _navigationService;
	private readonly INavigationViewService _navigationViewService;
	private readonly IJellyfinClient _jellyfinClient;

	public TitleBarViewModel(INavigationService navigationService,
							 INavigationViewService navigationViewService,
							 IJellyfinClient jellyfinClient)
	{
		_navigationService = navigationService;
		_navigationViewService = navigationViewService;
		_jellyfinClient = jellyfinClient;

		navigationService.Navigated += NavigationService_Navigated;

		this.WhenAnyValue(x => x.SearchTerm)
			.Where(x => x is { Length: >= 3 })
			.Throttle(TimeSpan.FromSeconds(1))
			.SelectMany(jellyfinClient.Search)
			.WhereNotNull()
			.Where(x => x.Items is { Count : > 0})
			.ObserveOn(RxApp.MainThreadScheduler)
			.Subscribe(result => SearchResults = result.Items!);
	}

	[ObservableProperty]
	public partial string Title { get; set; } = "";

	[ObservableProperty]
	public partial string Version { get; set; } = Assembly.GetEntryAssembly()!.GetName().Version!.ToString();

	[ObservableProperty]
	public partial bool CanGoBack { get; set; }

	[ObservableProperty]
	public partial UserDto? User { get; set; }

	[ObservableProperty]
	public partial string SearchTerm { get; set; }

	[ObservableProperty]
	public partial List<BaseItemDto> SearchResults { get; set; }

	public void TogglePane()
	{
		_navigationViewService.TogglePane();
	}

	public void GoBack()
	{
		_navigationService.GoBack();
	}

	[RelayCommand]
	private async Task Logout()
	{
		User = null;
		await _jellyfinClient.Logout();
	}

	private void NavigationService_Navigated(object sender, Microsoft.UI.Xaml.Navigation.NavigationEventArgs e)
	{
		CanGoBack = _navigationService.CanGoBack;
	}

}
