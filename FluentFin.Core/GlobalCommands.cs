﻿using CommunityToolkit.Mvvm.Input;
using FluentFin.Contracts.Services;
using FluentFin.Core.Contracts.Services;
using FluentFin.Core.ViewModels;
using Jellyfin.Sdk.Generated.Models;

namespace FluentFin.Core;

public partial class GlobalCommands(INavigationServiceCore navigationService,
									IJellyfinClient jellyfinClient)
{
	[RelayCommand]
	public void PlayDto(BaseItemDto dto)
	{
		navigationService.NavigateTo("FluentFin.ViewModels.VideoPlayerViewModel", dto);
	}

	[RelayCommand]
	public async Task ToggleWatched(BaseItemDto dto)
	{
		await jellyfinClient.SetPlayed(dto, !(dto.UserData?.Played ?? false));
	}

	[RelayCommand]
	public async Task ToggleFavorite(BaseItemDto dto)
	{
		await jellyfinClient.SetIsFavorite(dto, !(dto.UserData?.IsFavorite ?? false));
	}

	[RelayCommand]
	public void DisplayDto(BaseItemDto dto)
	{
		switch (dto.Type)
		{
			case BaseItemDto_Type.Movie:
				navigationService.NavigateTo(typeof(MovieViewModel).FullName!, dto); break;
			case BaseItemDto_Type.Series:
				navigationService.NavigateTo(typeof(SeriesViewModel).FullName!, dto); break;
			case BaseItemDto_Type.Season:
				navigationService.NavigateTo(typeof(SeasonViewModel).FullName!, dto); break;
			default:
				break;
		}
	}

	[RelayCommand]
	public void NavigateToSegmentsEditor(BaseItemDto dto)
	{
		navigationService.NavigateTo("FluentFin.ViewModels.MediaSegmentsEditorViewModel", dto);
	}

	[RelayCommand]
	public async Task DeleteItem(BaseItemDto dto)
	{
		await jellyfinClient.DeleteItem(dto);
	}
}
