using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace AppVacances
{
    public partial class RoundedImageControl : ContentView
    {
        public RoundedImageControl()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty ImageProperty = BindableProperty.Create(nameof(Image), typeof(ImageSource), typeof(RoundedImageControl), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            if (newValue is ImageSource image && bindable is RoundedImageControl)
            {
                ((RoundedImageControl)bindable).image.Source = (ImageSource)newValue;
            }
        });

        public static readonly BindableProperty SizeProperty = BindableProperty.Create(nameof(Frame), typeof(double), typeof(RoundedImageControl), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            if (newValue is Double frame && bindable is RoundedImageControl)
            {
                ((RoundedImageControl)bindable).frame.HeightRequest = (double)newValue;
                ((RoundedImageControl)bindable).frame.WidthRequest = (double)newValue;
                ((RoundedImageControl)bindable).frame.CornerRadius = Convert.ToSingle((double)newValue);
            }
        });

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            (sender as ImageButton).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();

            if(stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }

            (sender as ImageButton).IsEnabled = true;
        }

        public ImageSource Image
        {
            get
            {
                return (ImageSource)GetValue(ImageProperty);
            }

            set
            {
                SetValue(ImageProperty, value);
            }
        }

        public Double Size
        {
            get
            {
                return (Double)GetValue(SizeProperty);
            }

            set
            {
                SetValue(SizeProperty, value);
            }
        }
    }
}
