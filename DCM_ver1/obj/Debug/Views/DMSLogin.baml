   M S B A M L   `   `   `  ����C  ?DCM_ver1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DCM_ver1.PropertiesDCM_ver1.Properties  5      /clr-namespace:DCM_ver1.ViewsDCM_ver1.Views  5      9!clr-namespace:DCM_ver1.ViewModelsDCM_ver1.ViewModels  5          DCM_ver1.Views.DMSLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2resx!clr-namespace:DCM_ver1.Properties     5      .localclr-namespace:DCM_ver1.Views     5      0vm!clr-namespace:DCM_ver1.ViewModels     5      $	��200��5
      $	��500��6   
�������  � DataContext  5      (   "DCM_ver1.ViewModels.LoginViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $. (pack://application:,,,/Styles/Style.xaml?�6%   %    5      .��5      �� #   DCM_ver1.Properties.Resources   grpLogin#��Z 6   .��5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      � $��0��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��0��6      labelNormal#��[  6,      labelLoginID#��Z 6Q   �� 5      $��1��6     txtboxNormal#��[ 6.   ��6T   �� *	LoginName+5       5!      � 5"      $��1��6   .+�5#      �� $ 
Horizontal=�6   .+�5$      �� $��0��6   #��[  6,      labelLoginPass#��Z 6Q   �� 5%      $��1��6   #��[ 6.   ��6T   �� *LoginPassword+5&      5)      � 5*      $��2��6   .+�5+      �� $ 
Horizontal=�6   $��Right=�66   .+�5,      ��   
btntNormal#��[ 6   	   	btnCancel#��Z	 6C   �� 5-      #��[ 6   
   btnLogin#��Z
 6C   ��5.      ��  �� Path$ LoginCommand�5/      50      51      52      53      