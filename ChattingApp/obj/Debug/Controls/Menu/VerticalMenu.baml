   M S B A M L   `   `   `  ����F  BChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChattingAppChattingApp  5      K GChattingApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:ChattingApp.Core;assembly=ChattingApp.CoreChattingApp.Core 5          ChattingApp.VerticalMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ChattingApp     5      Icore8clr-namespace:ChattingApp.Core;assembly=ChattingApp.Core     5      .��5
      �� 
���������5      �� *Items+��5   
   �� 5      .R�5      � .+�5      � y�6   �� *Type+  �� 	Converter  3   -ChattingApp.MenuItemTypeToVisibilityConverter   �� ConverterParameter$ Header��.+�5      �� $	��0.5��6!      ForegroundDarkBrush#��[  6.   �� 5        LatoRegular#��[ 5   $     FontSizeSmall#��[ 5   $    �� Padding$ 0 5 10 5q�5   $     ForegroundLightBrush#��[ 5   $   $
��Left=�5   $   #��[  5    $   ��5   $   �� *Text+5    $   5"      �� 5%      #��[ 6    �� CornerRadius$ 8��5&       �� Padding$ 5q�5'      y�5(      �� *Type+    $ TextAndIcon�� � Triggers 5*      :� 5,       :� RoutedEvent$ 
MouseEnter��6+   .[�5-   "   �� .��5.   &   �� .��5/   *   ��   WordBlue	 �� To# [ 69    g� Duration$ 0:0:0.1D�50   9   	 �� TargetProperty$	 Background.Color�51   9   �� 52   *     ForegroundLight# [ 69   $ 0:0:0.1D�53   9   $	 Foreground.Color�54   9   
 �� 
TargetName$

 icon��55   9   �� 56   *   # [ 69   $ 0:0:0.1D�57   9   $	 Foreground.Color�58   9   $

 text��59   9   5:   '   5;   #   5<      :� 5?      $ 
MouseLeave��6+   .[�5@   "   �� .��5A   &   �� .��5B   *   �� # [ 69   $ 0:0:0.1D�5C   9   $	 Background.Color�5D   9   �� 5E   *     ForegroundDark# [ 69   $ 0:0:0.1D�5F   9   $	 Foreground.Color�5G   9   $

 icon��5H   9   �� 5I   *     ForegroundVeryDark# [ 69   $ 0:0:0.1D�5J   9   $	 Foreground.Color�5K   9   $

 text��5L   9   5M   '   5N   #   5O      ._�5S      �  � ColumnDefinitions 5T      �� 5V   "   $
��Auto �63   �� 5X   "   $��* �63   .+�5\      �� $
��icon��6(   $ 5q�5]   (     FontAwesome#��[ 5^   (   #��[  5`   (   ��5_   (   �� *Icon+  0   *ChattingApp.IconTypeToFontAwesomeConverter  5`   (   �� 5d      $
��text��6(   $��1��5e   (   $��5 0 5 0q�5f   (   $��Center=�5g   (    	 ForegroundVeryDarkBrush#��[	 5h   (   #��[ 5i   (   ��5j   (   �� *Text+5k      5m      5o      5q      5s      5t      