   M S B A M L   `   `   `  ����F  BChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChattingAppChattingApp  5      K GChattingApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:ChattingApp.Core;assembly=ChattingApp.CoreChattingApp.Core 5      %    ChattingApp.ChatListItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ChattingApp     5      Icore8clr-namespace:ChattingApp.Core;assembly=ChattingApp.Core     5        � 	Resources  5         ContentStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name  ForegroundLightBrush J� InputBindings d� MouseAction �� Command	 �Name
 � ColumnDefinitions �� 	Converter.   (ChattingApp.BooleanToVisibilityConverter �� ConverterParameter �� Padding+   %ChattingApp.StringRGBToBrushConverter �� RelativeSource �� CornerRadius  FontSizeLarge  LatoRegular �� Padding  WordBlueBrush  ForegroundDarkBrush �� Triggers :� RoutedEvent  WordVeryVeryLightBlue	 �� To g� Duration �� 
TargetName �� TargetProperty P� Property P� Value �� 
TargetName �� Value �� Binding  WordVeryVeryLightBlueBrush��%e  &	        7  7  7  7  7  7  7  7  7  7  7  �� 5   
   " ��6%   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
background��6!   8��   5      d� 5   "   $ 	LeftClicke�6/    6G   �� *OpenMessageCommand+._�5      � $	 	container��6#   
������ 
 5   "   �� 5   &   $
��Auto �67   �� 5   &   $��* �67   .+�5#   "   �� 
���  ��$��4��5$   %   $
��Left=�5%   %   y�5&   %   �� *NewContentAvailable+   $
 True���� 5*   "   $��0��6)   $
 8 15q�5+   )   ._�5.   &   �� $��40��5/   -   ��5.   -   �� *ProfilePictureRGB+   ��50   -   �� *ActualHeight+ �� *Self+ 51   -   �� *ActualHeight+ �� *Self+._�53   *   �� $��Center=�54   0   $��Center=�55   0   8�� 8�� 8�� ��53   4   �� *
Initials+58   0   5:   '   5;   #   �� 5>   "   $��1��6)   $ 0 0 15 0q�69   ._�5?   &   �� $��Center=�61   .+�5A   *   �� $ 0 0 0 2q�5B   4   $��CharacterEllipsis=�5C   4   8�� 8�� ��5A   4   �� *Name+5E   4   �� 5G   *   $ 0 2 0 0q�5H   4   8�� $��CharacterEllipsis=�5J   4   8�� ��5G   4   �� *	Message+5K   4   5L   '   5M   #   5O      5P       5S      :� 5T      $ 
MouseEnter��6+   .[�5U   "   �� .��5V   &   �� .��5W   *   �� 8  $ 0:0:0.3D�6e   $ 	container��6x   $ Background.Color�6�   5X   '   5Y   #   5Z      :� 5[      $ 
MouseLeave��6+   .[�5\   "   �� .��5]   &   �� .��5^   *   �� $ TransparentX�69   $ 0:0:0.3D�6J   $ 	container��6]   $ Background.Color�6   5_   '   5`   #   5a      P� 5b       � {� .  . �5c   "   �� $ 	container��6?   8 	  � ��6V   5d      �� 5e      $
 True��6I    6*   �� *
IsSelected+.a�5f   "   �� $ 
background��6?   8 
  � ��6W   5g      5i      5k      5l      5m      .��5o      �� #��[  5p      5t      