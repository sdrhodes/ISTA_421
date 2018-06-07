## Steven Rhodes
### C# Chapter 25 Homework

### 1. What is the purpose of the Universal Windows Platform? What was the name of the predecessor to UWP?
The purpose of this platform is to help develop universal apps that run on Windows 10, Windows 10 Mobile, Xbox One and HoloLens without the need to be re-written for each.

WinRT

### 2. Describe in detail how the lifetime of a UWP app differs from a traditional desktop application.
https://docs.microsoft.com/en-us/windows/uwp/launch-resume/images/updated-lifecycle.png

not running > activated > running in background > leaving background> running in foreground > entered background > running in background > suspending > suspended> resuming > running in background

### 3. Describe two ways you can set and modify the properties of controls.
Properties can be modified on the XAML window and with style sheets

### 4. Describe the two layout schemes of UWP apps that we constructed in class.
Tabular and columnar

### 5. Describe three ways you can use the Visual State Manager to adapt the layout of UWP apps
Different versions of Mainpage.xaml can be created, one for each device family

### 6. Describe how you can modify multiple properties of multiple controls with one document. How do you connect this modification document with your UWP application?
Properties can be altered of a control in a style sheet by creating a new sheet and linking it to the app.xaml file