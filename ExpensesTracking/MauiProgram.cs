﻿using ExpensesTracking.Repository;
using ExpensesTracking.ViewModels;

namespace ExpensesTracking;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddRepositoryLayer();
		builder.Services.AddViewModelsLayer();

		return builder.Build();
	}
}
