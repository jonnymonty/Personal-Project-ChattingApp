   M S B A M L   `   `   `  ����F  BChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:ChattingAppChattingApp  5      K GChattingApp.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:ChattingApp.Core;assembly=ChattingApp.CoreChattingApp.Core 5      ,    &ChattingApp.ChatMessageListItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:ChattingApp     5      Icore8clr-namespace:ChattingApp.Core;assembly=ChattingApp.Core     5      .��5
      ��   �� Padding$  5q�6   ._�5   
   � .+�5      �� $	��Top=�6   $
��Left=�5      $��0 7.5 0 7.5q�5      $��35��5      
��� � �   BackgroundLightBrush#��[  5      $��1q�5      y�5      �� *
SentByMe+ �� 	Converter .   (ChattingApp.BooleanToVisibilityConverter   �� CornerRadius 5      �� *ActualWidth+ �� RelativeSource �� *Self+��5      �� *ActualWidth+ �� *Self+._�5      �� $��Bottom=�5      $��Center=�5        ForegroundLightBrush#��[ 5        LatoRegular#��[ 5      $��7,0,7,8q�6F   ��5      �� *
Initials+5   F   5      � 5!      $��	25 0 25 0q�6   ��5"      �� *
SentByMe+ .   (ChattingApp.SentByMeToAlignmentConverter   � Triggers 5$      :� 5'       :� RoutedEvent$ 
MouseEnter��6#   .[�5(      �� .��5)      ��  �� 
TargetName$ ExtraDetails��6)    �� TargetProperty$ Opacity�6N   .��5*   "   W� 	 W� To$ 1X�62   	 g� Duration$	 
00:00:00.5D�69   5+      5,      5-      :� 50      $ 
MouseLeave��6#   .[�51      �� .��52      �� $ ExtraDetails��6)   $ Opacity�6N   .��53   "   W� $ 0X�62   $	 
00:00:00.5D�69   54      55      56      
 � RowDefinitions
 59      �� 5:      $
��Auto �6$   �� 5;      $
��Auto �6$   .+�5?      � 
 5A      �� 5B      $
��Auto �6(   �� 5C      $
��Auto �6(   .+�5G      �� $	��Top=�5H      ��5G      �� *
SentByMe+   ._�5I      ��   SpinningText#��[ 6$   #��[ 5J        �� Padding$ 20q�5K        � DataContext 5L       �� *ImageAttachment+y�5M       �� *ImageLoaded+ 2   ,ChattingApp.BooleanToVisibilityGoneConverter   �� ConverterParameter$
 True�� �� FallbackValue$ 	Collapsed��5O      �� 5R      $ 10��6   $��0 0 0 15q�5S      ._�5U      �� �   �ChattingApp.BaseAttachedProperty`2[[ChattingApp.ClipFromBorderProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value . �   �ChattingApp.BaseAttachedProperty`2[[ChattingApp.FadeInImageOnLoadProperty, ChattingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null],[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Value . $	��600��5Y        5U       �� *ImageAttachment+��5X       �� *LocalFilePath+ �� NotifyOnTargetUpdated . 5Y       5\      � 5_      $��1��6   ��5`      �� *
SentByMe+   y�5a      �� *
HasMessage+   
 5c      �� 5d      $
��Auto �6,   �� 5e      $
��Auto �6,   �� 5f      $
��Auto �6,   .+�5j      �� $ 10��6!   $  15q�5k   !   ��5l   !   �� *
SentByMe+ /   )ChattingApp.SentByMeToBackgroundConverter  ._�5p      �� $��Center=�6(   $
��Wrap=�5q   (   #��[ 5r   (     WordDarkBlueBrush#��[ 5s   (   ��5t   (   �� *	Message+5w      F� 5z      $��1��6    K� ZIndex$ 1��5|      $��
15 -1 15 0q�5}      "����        �@KL @KL р��     	��5z   ,   �� *
SentByMe+   ��5{      �� *
SentByMe+   5~      �� 5�      -   5        $��ExtraDetails��5�   %    �� Orientation$ 
Horizontal=�5�       J� Opacity$ 0Q�5�      $��1��5�      ��5�      �� *
SentByMe+   $
 True��.+�5�      �� #��[ 5�         FontSizeSmall#��[ 5�       #��[ 5�       $��	15 0 15 0q�5�       ��5�   (   �� *MessageSentTime+ ,   &ChattingApp.TimeToDisplayTimeConverter  5�       �� 5�      #��[ 5�       #��[ 5�       #��[ 5�       ��5�   (   �� *MessageReadTime+ )   #ChattingApp.TimeToReadTimeConverter  5�       5�      5�      5�      5�      5�      5�      5�      