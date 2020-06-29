# TCS Devicemanagement 

This app was developed as a part of the internship programme in TCS,Kolkata.


The app has been written with the Xamarin platform of Visual studio.
It runs on all mobile platforms . The backend and the middle ware were also developed. 

The app is used for managing issue and return of devices in TCS .It contains a chatbot which fascilities tasks like like booking a device and returning it,including several others.

Chat bot has been developed using google dialogueflow .Speech recognition has been built using Azure cloud services. 

1.IspeechtoText.cs: This contains the interface for speech recognition in Android Platform

2.MainPage.cs: This contains the lambda function to call dependency services.

MobileApp.Android

1.SpeechToText_Android.cs : Implementation of the interface IspeechToText in Android Platform.

2.MAinActivity.cs : contains OnActivityResult method which is an overridden method of activity class.


## To deploy: 

Install Xamarin plugin of Visual Studio and clone the repo.


A running presentation of the app can be seen in the following youtube link.

<ahref> https://www.youtube.com/watch?v=r-KFqx5vDWg </ahref>

