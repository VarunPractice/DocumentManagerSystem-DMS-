   M S B A M L   `   `   `  ����C  ?DCM_ver1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DCM_ver1DCM_ver1  5   	   /clr-namespace:DCM_ver1.ViewsDCM_ver1.Views  5   	   9!clr-namespace:DCM_ver1.ViewModelsDCM_ver1.ViewModels  5   
       DCM_ver1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DCM_ver1     5   	   .viewsclr-namespace:DCM_ver1.Views     5   	   0vm!clr-namespace:DCM_ver1.ViewModels     5   
     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)   
������� � DataContext 5      -   'DCM_ver1.ViewModels.MainWindowViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $. (pack://application:,,,/Styles/Style.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      (   "DCM_ver1.Views.DocumentControlView  5!      � 5"   
   $��1��6   .+�5%      *   $DCM_ver1.Views.DocumentEditorControl  5&      � 5'   
   $��2��6   .+�5*      /   )DCM_ver1.Views.RecentDocumentsControlView  5+      5,      5-      