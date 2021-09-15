<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/260203915/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T885530)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
*Files to look at*:
- [MainView.xaml](./CS/ValidationErrorHostBehavior/Views/MainView.xaml)
- [MainViewMode.cs](./CS/ValidationErrorHostBehavior/ViewModels/MainViewModel.cs)

# WPF - How to validate a View with ValidationErrorsHostBehavior

The example shows how to use [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior) to validate a View.

## Overview

You can define the [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior) for the root element to tracks all validation errors within the View. To enable validation error notification, set the **NotifyOnValidationError** and **ValidatesOnDataErrors** properties to `true`.

Use the [ValidationErrorsHostBehavior.HasErrors](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior.HasErrors) property to check whether a validation error occured.

## Documentation

- [ValidationErrorsHostBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.ValidationErrorsHostBehavior)
- [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
