   M S B A M L   `   `   `  ����F  BChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChattingAppChattingApp  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ScrollBarThumb  �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels  WordDarkBlueBrush �� CornerRadius �� RelativeSource �Name	 �� Padding
 ]�Name J� IsMouseOver ]� DecreaseRepeatButton J� Opacity �� PageUpCommand ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb �� Triggers P� Property P� Value �� PageLeftCommand �� PageRightCommand � ColumnDefinitions � RowDefinitions ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4   .System.Windows.Automation.AutomationProperties    AutomationId  � Cursor! �� ScrollableHeight" � Maximum# � Minimum*$ �� #ComputedVerticalScrollBarVisibility% �� ViewportHeight& �� ViewportSize' � Value( �� Mode) �� ScrollableWidth* �� Orientation,+ �� %ComputedHorizontalScrollBarVisibility, �� ViewportWidth- �� Triggers. :� RoutedEvent	/ W� To0 g� Duration1 �� 
TargetName2 �� TargetProperty�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      #localclr-namespace:ChattingApp  5      %�  &	        7  '�� .    7   7   '�� z    �� 5      "  n�6#   .�5   
   ��  �@�OverridesDefaultStyle . 62   �� 5   
    � �� .  6&   �� 5   
    � �� 5	      �� 5
      " n�6"   .R�5      �� $ 	rectangle��6    . 8��  $ 3��5   !   #��z��5   !   #��z��5   !   5      5      5      �� 5      "  ��6   .�5   
   ��  �@��IsPressAndHoldEnabled .  69   �� 5   
    �@��IsFlicksEnabled .  63   �� 5   
    � ��$ 14��6"   �� 5   
    � ��$ 	-14 0 0 0q�6#   �� 5   
    � �� 6%   �� *Width+ �� *Self+�� 5   
    � �� 5      �� 5      " ��6"   .R�5      � $ Bg��6    . 
������ .+�5!      �� $		 0 4q�6!   ._�5"      ]� $
 
PART_Track��6$   ��. #{�z 5$       $��6��5%       $��Center=�5&        5'   "   �� 5(   &   $ 0Q�63   #��Z 6?    5*   "   �� 5+   &   $ 0Q�63   #��Z 6?    5-   "   n� 5.   &   8��  6,   50      51      52      53      55       56   
   P� 57       �@��Orientation$ 
Horizontal=�6-   . �58      ��  � ��$
 Auto��6*   �� 59       � ��$ 0��6-   �� 5:       � ��$ 14��6+   �� 5;       � �� 6.   �� *Height+ �� *Self+�� 5<       � ��$ 	0 -14 0 0q�6+   �� 5>       � �� 5?      �� 5@      " ��6*   .R�5A      � $ Bg��6#    . .+�5B   "   ]� $
 
PART_Track��6(   #{�z 5C   %   $��6��5D   %    5F   &   �� 5G   *   $ 0Q�67   #��Z 6C    5I   &   �� 5J   *   $ 0Q�67   #��Z 6C    5L   &   n� 5M   *   8�� 60   5O   #   5P      5Q      5S      5T      5V      �� 5X      "  ��6   .�5Y   
   ��  � �� 5Z      �� 5[      " ��6"   .R�5\      � $
 Grid��6   #��z��6)    5]      �� 5^      $��* �6/   �� 5_      $
��Auto �6/    5a      �� 5b      $��* �6,   �� 5c      $
��Auto �6,   .+�5e      �� $ Corner��6$   $��1��64   #��� ��6D   $��1��6�   �� 5f      $! PART_ScrollContentPresenter��61   # z��6V    .   .  #��z��6�   #��z��6�   $��0��6  #��z��6.  $��0��6Q  �� 5h      $ PART_VerticalScrollBar��6$   $	 0.2Q�5i   $   $ VerticalScrollBar��5j   $   $  Arrow��5k   $   $��1��5l   $   #" z! 5m   $   $# 0Q�5n   $   $��0��5o   $   #y�z$ 5p   $   #& z% 5r   $   ' 5q   $   �� *VerticalOffset+$( OneWay=� �� *TemplatedParent+5r   $   �� 5t      $ PART_HorizontalScrollBar��6$   $	 0.2Q�5u   $   $ HorizontalScrollBar��5v   $   $  Arrow��5w   $   $��0��5x   $   #" z) 5y   $   $# 0Q�5z   $   $* 
Horizontal=�5{   $   $��1��5|   $   #y�z+ 5}   $   #& z, 5   $   ' 5~   $   �� *HorizontalOffset+$( OneWay=� �� *TemplatedParent+5   $   5�      - 5�      :� 5�      $. 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� $/ 1X�66   $0 0:0:0.3D�6=   $1 PART_VerticalScrollBar��6P   $2 Opacity�6   W� 5�   &   $/ 1X�66   $0 0:0:0.3D�6=   $1 PART_HorizontalScrollBar��6P   $2 Opacity�6�   5�   #   5�      5�      :� 5�      $. 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� $	/ 0.2X�66   $0 0:0:0.3D�6?   $1 PART_VerticalScrollBar��6R   $2 Opacity�6�   W� 5�   &   $	/ 0.2X�66   $0 0:0:0.3D�6?   $1 PART_HorizontalScrollBar��6R   $2 Opacity�6�   5�   #   5�      5�      5�      5�      5�      5�      