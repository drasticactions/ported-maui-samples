﻿namespace DynamicUnevenListCells;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        BindingContext = this;
        InitializeComponent();

        var items = Enumerable.Range(0, 10);
        listView.ItemsSource = items;
    }

    void OnImageTapped(object sender, EventArgs args)
    {
        var image = sender as Image;
        var viewCell = image.Parent.Parent as ViewCell;

        if (image.HeightRequest < 250)
        {
            image.HeightRequest = image.Height + 100;
            viewCell.ForceUpdateSize();
        }
    }
}

