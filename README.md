<!-- default badges list -->
<!-- default badges end -->
# WPF MVVM Framework - Validate a View with ValidationErrorsHostBehavior

The example shows how to use [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior) to validate a View. 

## Overview

You can define [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior) for the root element to track all validation errors within the View. To enable validation error notifications, set the **NotifyOnValidationError** and **ValidatesOnDataErrors** properties to `true`.

Use the [ValidationErrorsHostBehavior.HasErrors](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior.HasErrors) property to check whether a validation error occured.

<!-- default file list --> 
## Files to Look At:
- [MainView.xaml](./CS/ValidationErrorHostBehavior/Views/MainView.xaml)
- [MainViewMode.cs](./CS/ValidationErrorHostBehavior/ViewModels/MainViewModel.cs)
<!-- default file list end -->

## Documentation

- [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
