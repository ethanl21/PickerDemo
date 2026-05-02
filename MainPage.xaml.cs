using Microsoft.Maui.Controls;

namespace PickerDemo;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		SetupPickers();
	}

	void SetupPickers()
	{
		BasicPicker.SelectedIndexChanged += (s, e) =>
		{
			if (BasicPicker.SelectedIndex >= 0)
				BasicPickerResult.Text = $"Selected: {BasicPicker.Items[BasicPicker.SelectedIndex]}";
		};

		TitlePicker.SelectedIndexChanged += (s, e) =>
		{
			if (TitlePicker.SelectedIndex >= 0)
				TitlePickerResult.Text = $"Selected: {TitlePicker.Items[TitlePicker.SelectedIndex]}";
		};

		StyledPicker.SelectedIndexChanged += (s, e) =>
		{
			if (StyledPicker.SelectedIndex >= 0)
				StyledPickerResult.Text = $"Selected: {StyledPicker.Items[StyledPicker.SelectedIndex]}";
		};

		ManyItemsPicker.SelectedIndexChanged += (s, e) =>
		{
			if (ManyItemsPicker.SelectedIndex >= 0)
				ManyItemsResult.Text = $"Selected: {ManyItemsPicker.Items[ManyItemsPicker.SelectedIndex]}";
		};

		PreSelectedPicker.SelectedIndexChanged += (s, e) =>
		{
			if (PreSelectedPicker.SelectedIndex >= 0)
				PreSelectedResult.Text = $"Selected: {PreSelectedPicker.Items[PreSelectedPicker.SelectedIndex]}";
		};

		PreSelectedPicker.SelectedIndex = 3;
	}
}