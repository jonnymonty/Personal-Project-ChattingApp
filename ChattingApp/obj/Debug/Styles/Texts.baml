   M S B A M L   `   `   `  ����F  BChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChattingAppChattingApp  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   
HeaderText  BaseTextBlockStyle �� BasedOn �� Property  ForegroundMainBrush �� Value  	BaseStyle  FontSizeXXLarge  LatoRegular  WordBlueBrush  ForegroundLightBrush  ForegroundVeryDarkBrush �� 
TargetType ��Name J� SnapsToDevicePixels ��Name ��Name	 J� IsHitTestVisible

 � Tag 	 LatoThin �� Padding �� Triggers �� Binding �� RelativeSource �� Value �� Triggers P� Property P� Value �� 
TargetName�    �ChattingApp.BaseAttachedProperty`2[[ChattingApp.MonitorPasswordProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]] �� 	Converter.   (ChattingApp.BooleanToVisibilityConverter 
 SpinningText  FontAwesome �� 	Resources  Key �� TargetProperty W� From	 W� To g� Duration g� RepeatBehavior �� Self �� Path N� EnterActions ��Name  Spin N� ExitActions  �� BeginStoryboardName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      #localclr-namespace:ChattingApp  5      %�  &	        7  7  '�� �     7  7  7  7  7  7  7 	 7  'G� �    7  7  7  7  7  7  7 	 7  &	
 �
    7  7  7  �� 5      "  ��6   8   .�5   
   ��  � ��8  6'   �� 5   
    � ��$ Center=�6.   �� 5   
    � ��$ Center=�60   �� 5	   
    � ��$	 0 6q�6#   5
      �� 5      "  ��6   8   .�5   
   ��  � ��8  6%   �� 5   
    � ��8  6'   �� 5   
    � ��$ 10q�6$   �� 5   
    � ��$	 0 5q�6#   �� 5   
    � ��8  6(   �� 5   
    � ��$ 0 0 0 1q�6,   �� 5   
    � ��8  6'   �� 5   
    � ��8  6'   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      � .+�5      �� $ border��6!   #��z��5   !   #��z��5   !   #��z��5    !    . ._�5"      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5#      �� 5%      $ placeholder��5'   $   	 .  #��z
 5&   $   8�� # z��5)   $   $��Center=�5*   $   #��z��5+   $   8�� ��5.      �� 5/   "   "  ��6(   .�50   &   ��  � y�$ 	Collapsed=�6C    51   &   �� 52   *    66   �� *Text+ �� *TemplatedParent+  6�   .a�53   .   ��  � y�$ Visible=�6K   54   +   56   #   58      5:       5<      P� 5=       � {� .  . �5>      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5?      P� 5@       �@J�IsMouseOver . . �5A      �� $ border��6<    � �� �	#FF7EB4EA6P   5B      P� 5C       �@J�IsKeyboardFocused . . �5D      �� $ border��6<    � �� �	#FF569DE56P   5E      5G      5I      5K      �� 5M      "  G�6   8   .�5O   
   ��  � ��8  6%   �� 5P   
    � ��8  6'   �� 5Q   
    � ��$ 10q�6$   �� 5R   
    � ��$	 0 5q�6#   �� 5S   
    � ��8  6(   �� 5T   
    � ��$ 0 0 0 1q�6,   �� 5V   
    � ��8  6'   �� 5W   
    � ��8  6'   �� 5Y   
    �@  Value . 6@   �� 5[   
    � �� 5\      �� 5]      " G�6"   .R�5_      � .+�5`      �� $ border��6!   #��z��5a   !   #��z��5b   !   #��z��5c   !    . ._�5e      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5f      �� 5h      $ placeholder��5j   $   	 .  #��z
 5i   $   8�� #��z��5l   $   # z��5m   $   $��Center=�5o   $   #��z��5p   $   8�� y�5n   $   �� *local:HasTextProperty.Value+   5}      5       5�      P� 5�       � {� .  . �5�      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5�      P� 5�       �@J�IsMouseOver . . �5�      �� $ border��6<    � �� �	#FF7EB4EA6P   5�      P� 5�       �@J�IsKeyboardFocused . . �5�      �� $ border��6<    � �� �	#FF569DE56P   5�      5�      5�      5�      �� 5�      "  ��6   8   .�5�   
   ��  � ��8  6'   �� 5�   
    � ��$	 ��6!   �� 5�   
    �@J�RenderTransformOrigin$ 0.5, 0.5&�62   �� 5�   
    � z� 5�      �� 5�      5�       5�   
   ���� 5�      Spin .��5�      W� $9 3(UIElement.RenderTransform).(RotateTransform.Angle)�5�      $ 0X�5�      $	 360X�5�      $ 0:0:2D�5�      $ Forever��5�      5�      5�       5�   
   �� 5�       6   �� # Z $ 	IsVisible� True6l    5�      �� 5�      $ SpinStoryboard��6&   8�� 6<    5�      �� 5�      $  SpinStoryboard��6'   5�      5�      5�      