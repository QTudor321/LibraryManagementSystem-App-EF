   M S B A M L   `   `   `  ����R  NLibraryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LibraryManagementSystem.WindowsLibraryManagementSystem.Windows  5   	   7    1LibraryManagementSystem.Windows.LibraryMainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:LibraryManagementSystem.Windows     5   	     � Title$  LibraryMainWindow��5   	   $	��450��6#   $	��800��60   .��5
      � .+�5   
   �� $
��Fill=�6�    �� StretchDirection$
 Both=�6�   $��/Images/LibraryImage.png��6�   $��61,0,0,0q�6�   ��6   �� *&$SystemParameters.PrimaryScreenHeight+��6I   �� *%#SystemParameters.PrimaryScreenWidth+6�   ]� 5   
   $��False��6   $��	0,0,739,0q�6*   .+�5      �� $
��Left=�6   
���   �$��3q�6?   $��63��6S   $	��431��6^   ._�5      �� -   5        $��6,226,0,151q�5      $
��Left=�6.   $��44��6I   ��5      �� 5       �� ImageSource$! /Images/LoanUtilityIcon.png��6%   6Q   5      5      5      �� 5   
   -   5        $
��Left=�5      $��49��6,   $��	10,54,0,0q�68   $	��Top=�6K   $��46��6c   ��5      �� 5      $  /Images/BookSearchIcon.png��6   6H   5      �� 5   
   -   5        $
��Left=�5      $��49��6,   $��
10,148,0,0q�68   $	��Top=�6L   $��42��6d   ��5      �� 5      $! /Images/UserProfileIcon.png��6   6I   5       �� 5!   
   -   5        $
��Left=�5!      $��47��6,   $��
10,379,0,0q�68   $	��Top=�6L   $��44��6d   ��5"      �� 5#      $ /Images/LogOut.png��6   6@   5%      �� 5&   
   $��Loan 
Book��6   $
��Left=�6.   $	��Top=�6I   $��61��6a   $��	0,192,0,0q�6l   �� 5'   
   $��User 
Profile��6   $
��Left=�61   $��	0,101,0,0q�6L   $	��Top=�6_   $��46��6w   �� 5(   
   $��Search 
Book��6   $
��Left=�60   $��0,12,0,0q�6K   $	��Top=�6]   $��53��6u   �� 5)   
   $��Log Out��6   $
��Left=�6"   $��	0,348,0,0q�6=   $	��Top=�6P   $��61��6h   �� 5*   
   $��	66,33,0,0q�6   .��5+      �  � ColumnDefinitions 5,      �� 5-      $	��105 �6'   �� 5.      $	��150 �6'   �� 5/      $	��150 �6'   �� 50      $	��150 �6'   �� 51      $	��150 �6'    � RowDefinitions 54      �� 55      $��15 �6$   �� 56      $	��200 �6$   �� 57      $	��200 �6$   �� 58      $	��200 �6$   .+�5:      � $��1��6   $��1��6$   $��10q�64   ��5;      �� 5<      $# /Images/BookTheDreamHotel.png��6%    j� Stretch$
 Fill=�6Q   5?      � 5@      $��1��6   $��2��6$   $��10q�64   ��5A      �� 5B      $  /Images/BookDreamCount.png��6%   $
 Fill=�6N   5E      � 5F      $��1��6   $��3��6$   $��10q�64   ��5G      �� 5H      $&  /Images/BookThisBookWillBury.png��6%   $
 Fill=�6T   5K      � 5L      $��1��6   $��4��6$   $��10q�64   ��5M      �� 5N      $# /Images/BookBufalloHunter.png��6%   $
 Fill=�6Q   5Q      � 5R      $��2��6   $��1��6$   $��10q�64   ��5S      �� 5T      $" /Images/BookFrankenstein.png��6%   $
 Fill=�6P   5W      � 5X      $��2��6   $��2��6$   $��10q�64   ��5Y      �� 5Z      $' !/Images/BookTheFallOfThEHouse.png��6%   $
 Fill=�6U   5]      � 5^      $��2��6   $��3��6$   $��10q�64   ��5_      �� 5`      $+ %/Images/BookCollectedGhostStories.png��6%   $
 Fill=�6Y   5c      � 5d      $��2��6   $��4��6$   $��10q�64   ��5e      �� 5f      $! /Images/BookGothicTales.png��6%   $
 Fill=�6O   5i      � 5j      $��3��6   $��1��6$   $��10q�64   ��5k      �� 5l      $" /Images/BookCatchingFire.png��6%   $
 Fill=�6P   5o      � 5p      $��3��6   $��2��6$   $��10q�64   ��5q      �� 5r      $" /Images/BookOneWrongStep.png��6%   $
 Fill=�6P   5u      � 5v      $��3��6   $��3��6$   $��10q�64   ��5w      �� 5x      $$ /Images/BookSplinterEffect.png��6%   $
 Fill=�6R   5{      � 5|      $��3��6   $��4��6$   $��10q�64   ��5}      �� 5~      $$ /Images/BookWhatWakesBells.png��6%   $
 Fill=�6R   5�      5�      5�      �� 5�   
   $ ��List of new released Books��6   
���   �
�������$
��Left=�6[   $��
180,20,0,0q�6v   $	��Top=�6�   $	��253��6�   $��20(�6�   �� 5�   
   -   5        $��	Subscribe��5�      $
��Left=�6%   $��	66,39,0,0q�6@   $	��Top=�6S   6k   5�      5�      