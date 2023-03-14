# Framework Programming Assignment 2

> This project is a responsive and reactive application that is able to add and delete items to a list. In addition, it is able to navigate between pages.

## User Interface 
> Below is the interface that the users will see. It consist of an entry and a enter button.

<img src="/img/User Interface.png" width="20%" height="20%" />

```
<Image Grid.ColumnSpan="2"
               Source="dotnet_bot.png"
               BackgroundColor="Orange" />
        
        <Entry Placeholder="Enter Something"
               Grid.Row="1"
               Text="{Binding Text}"/>

        <Button Text="Enter" 
                Command="{Binding AddCommand}"
                Grid.Row="1"
                Grid.Column="1"/>
```

## Data Binding with MVVM & XAML
> Using MVVM the application is able to react and response to the user's interaction. User are now able to add items and delete them.
- Add items

<img src="/img/data_binding 1.png" width="20%" height="20%"/>   <img src="/img/data_binding 2.png" width="20%" height="20%" />

User enter what they want on the input entry and click enter to add items. 
Here I added my `student ID` and `Name`

- Delete
<img src="/img/delete.png" width="20%" height="20%"/>

By holding and swiping item to the left and pressing delete, user are able to delte item.

```
<SwipeItem Text="Delete"
    BackgroundColor="Red"
    Command="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MainViewModel}}, Path=DeleteCommand}"
    CommandParameter="{Binding .}"/>
```

## Navigating between pages 
> When an item is clicked it will navigate to the detail page where it displays the details.

<img src="/img/details.png" width="20%" height="20%"/>  <img src="/img/details 2.png" width="20%" height="20%"/>  

```
<TapGestureRecognizer Command="{Binding Source={RelativeSource AncestorType={x:Type viewmodel:MainViewModel}}, Path=TapCommand}"
       CommandParameter="{Binding .}" />
```
 
## Connectivity
> If the device is not connected to the Internet it will display an alert and user are not able to add or delete any item.

<img src="/img/connectivity.png" width="20%" height="20%"/> 

Above I tried adding `Framework Programming`, because the wifi is off, it is not able to. Instead it diplay the alert.

```
if(connectivity.NetworkAccess != NetworkAccess.Internet)
      {
          await Shell.Current.DisplayAlert("Oh No!", "No internet", "OK");
          return;
      }
```
