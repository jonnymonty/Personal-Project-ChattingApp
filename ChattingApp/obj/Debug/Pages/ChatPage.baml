   M S B A M L   `   `   `  ����F  BChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChattingAppChattingApp  5      K GChattingApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:ChattingApp.Core;assembly=ChattingApp.CoreChattingApp.Core 5          ChattingApp.ChatPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ChattingApp     5      Icore8clr-namespace:ChattingApp.Core;assembly=ChattingApp.Core     5      -   5           ChattingApp.BasePage`1   Name$
  Page��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� 
������ $��2��5       K� ZIndex$ 1��5      y�5      �� *AnyPopupVisible+ �� 	Converter .   (ChattingApp.BooleanToVisibilityConverter   �� ConverterParameter$
 True�� J� InputBindings 5       d� 5!       d� MouseAction$ 	LeftClicke�6    �� Command 67   �� *PopupClickawayCommand+5#      � 5&   
   $��50��6    � ColumnDefinitions 5(      �� 5)      $��* �6#   �� 5*      $
��Auto �6#   .+�5.      �� $��2��5/         ForegroundLightBrush#��[  50        LatoRegular#��[ 51        FontSizeXLarge#��[ 52      $��Center=�53      $��Center=�54      ��5.      �� *DisplayTitle+54      �� 57      $��1��6   	 �� Orientation$	 
Horizontal=�6)   .+�5:      ��   IconGrowButton#��[ 6     FontAwesomeSearchIcon#��[ 5;      ��5<      �� *OpenSearchCommand+�� 5?      #��[ 6    # FontAwesomeEllipsisVerticalIcon#��[ 6A   5@      � 5C      $��2��6   �   �ChattingApp.BaseAttachedProperty`2[[ChattingApp.AnimateSlideInFromRightMarginProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]
   Value
 5D      �� *SearchIsOpen+ 5F      �� 5G      $
��Auto �6'   �� 5H      $��* �6'   .+�5L      �� #��[ 6     WordOrangeBrush#��[ 5M        FontAwesomeCloseIcon#��[ 5N      ��5O      �� *CloseSearchCommand+�� 5R      $��1��6   
 � Tag$ Search text...��5U      $��0 5 5 5q�5V        FontSizeRegular#��[ 5W      �   �ChattingApp.BaseAttachedProperty`2[[ChattingApp.FocusProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5S      �� *SearchIsOpen+��5T      �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�.��5X       5Y      �� 5[      
 �� Key$	 Esc��6L    6%   �� *ClearSearchCommand+6L   �� 5^      $ Return��6G    6%   �� *SearchCommand+6G   .��5_   -   5`      5b      5d      (   "ChattingApp.ChatMessageListControl  5g   
   -   5          Name$ ChatMessageList��5g   '   $��1��5i   '    � DataContext 5h   '   �� 5i   '   �� 5m   
   $��1��5n      $ 2��5o      $��Bottom=�5p      $
��Left=�5q      �   �ChattingApp.BaseAttachedProperty`2[[ChattingApp.AnimateSlideInFromBottomProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value 5m      �� *AttachmentMenuVisible+._�5s         ChattingApp.BubbleContent   6"   �� *AttachmentMenu+5u      � 5x   
   $��2��6   $ 3��5y      $��50��5z      $	��113��5{      #��[  5|       5~      �� 5�      $
��Auto �6#   �� 5�      $��* �6#   �� 5�      $
��Auto �6#   .+�5�      �� #��[ 6   $	��Top=�5�       	 FontAwesomePaperclipIcon#��[	 5�       
 ForegroundDarkBrush#��[
 5�      ��5�      �� *AttachmentButtonCommand+��5�      �� *	MinHeight+ �� RelativeSource ��  �� AncestorType$
 GridL�5�      �� 5�      -   5         ��Name$ MessageText��5�      $��1��5�      $ Write a message...��5�      �   �ChattingApp.BaseAttachedProperty`2[[ChattingApp.IsFocusedProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value . #��[ 5�      " �� VerticalScrollBarVisibility$
 Auto=�5�       �� TextWrapping$
 Wrap=�5�      $��Center=�5�      $��0q�5�      $��
0 10 10 10q�5�       �� 
AcceptsTab .  �� AcceptsReturn . ��5�      �� *PendingMessageText+$ PropertyChanged=�5�      �� 5�      $��2��6   $	 
Horizontal=�5�      $	��Top=�5�      $��0 0 8 0q�5�      .+�5�      �� #��[ 6     FontAwesomeEmojiIcon#��[ 5�      #��[ 5�      ��5�      �� *	MinHeight+ �� $
 GridL�5�      �� 5�      $
��Send��6   $��8q�5�      |�.    WordGreenBrush#��[ 5�      #��[ 5�      ��5�      �� *SendCommand+5�      5�      5�      5�      5�      