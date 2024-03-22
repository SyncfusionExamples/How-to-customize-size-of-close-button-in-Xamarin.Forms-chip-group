# How to customize size of close button in Xamarin.Forms chip group

The chip control supports to customize the background color, border color, close button color, and more. The chip control can be customized using the following properties:

## ShowCloseButton
 
The [ShowCloseButton](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html#Syncfusion_XForms_Buttons_SfChip_ShowCloseButton) property sets the visible state of close button in [SfChip](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html).

**[XAML]**

```
 <ContentPage.Content>
        <StackLayout Margin="8,8,8,8" >
           <buttons:SfChip  Text="James" 
                            WidthRequest="150"
                            HorizontalOptions="Center"
                            VerticalOptions="Center"
                            ShowCloseButton="true" >
           </buttons:SfChip>  
        </StackLayout>
    </ContentPage.Content>
```

**[C#]**

```
            SfChip chip = new SfChip();
            chip.Text = "James";
            chip.WidthRequest = 150;
            chip.HorizontalOptions = LayoutOptions.Center;
            chip.VerticalOptions = LayoutOptions.Center;
            chip.ShowCloseButton = true;
```
## ShowSelectionIndicator

The [ShowCloseButton](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html#Syncfusion_XForms_Buttons_SfChip_ShowSelectionIndicator
) property sets the visible state of close button in [SfChip](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html).

**[XAML]**
```

           <buttons:SfChip  Text="James" 
                            WidthRequest="150"
                            HorizontalOptions="Center"
                            VerticalOptions="Center"
                            ShowCloseButton="true"
                            ShowSelectionIndicator="true"
                            >
           </buttons:SfChip>  
       
```
**[C#]**

```
            SfChip chip = new SfChip();
            chip.Text = "James";
            chip.WidthRequest = 150;
            chip.HorizontalOptions = LayoutOptions.Center;
            chip.VerticalOptions = LayoutOptions.Center;
            chip.ShowCloseButton = true;
            chip.ShowSelectionIndicator = true;
```

## CloseButtonColor
The [CloseButtonColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html#Syncfusion_XForms_Buttons_SfChip_CloseButtonColor) property customizes the color of the close button in [SfChip](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html).

**[XAML]**

```
 
           <buttons:SfChip  Text="James" 
                            WidthRequest="150"
                            HorizontalOptions="Center"
                            VerticalOptions="Center"
                            ShowCloseButton="true"
                            CloseButtonColor="White"
                            >
           </buttons:SfChip>  
       
```

**[C#]**

```
            SfChip chip = new SfChip();
            chip.Text = "James";
            chip.ShowCloseButton = true;
            chip.CloseButtonColor = Color.White;
```
## BorderColor
The [BorderColor](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_BorderColor) property customizes the color of border in [SfChip](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html).

**[XAML]**

```
           <buttons:SfChip  Text="James" 
                            WidthRequest="150"
                            HorizontalOptions="Center"
                            VerticalOptions="Center"
                            BorderWidth="4"
                            BorderColor="Black"
                            >
           </buttons:SfChip>  
```

**[C#]**
```
            SfChip chip = new SfChip();
            chip.Text = "James";
            chip.WidthRequest = 150;
            chip.HorizontalOptions = LayoutOptions.Center;
            chip.VerticalOptions = LayoutOptions.Center;
            chip.BorderWidth = 4;
            chip.BorderColor = Color.Black;
```
## BorderWidth
The [BorderWidth](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfButton.html#Syncfusion_XForms_Buttons_SfButton_BorderWidth) property customizes the thickness of border in [SfChip](https://help.syncfusion.com/cr/xamarin/Syncfusion.XForms.Buttons.SfChip.html).

**[XAML]**

```
           <buttons:SfChip  Text="James" 
                            WidthRequest="150"
                            HorizontalOptions="Center"
                            VerticalOptions="Center"
                            BorderWidth="8"
                            BorderColor="Black"
                            >
           </buttons:SfChip>  
```

**[C#]**

```
            SfChip chip = new SfChip();
            chip.Text = "James";
            chip.WidthRequest = 150;
            chip.HorizontalOptions = LayoutOptions.Center;
            chip.VerticalOptions = LayoutOptions.Center;
            chip.BorderWidth = 8;
```