   M S B A M L   `   `   `  ����R  NLibraryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:LibraryManagementSystem.UsersWindows$LibraryManagementSystem.UsersWindows  5   	   F    @LibraryManagementSystem.UsersWindows.SubscribedLibraryMainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Dlocal2clr-namespace:LibraryManagementSystem.UsersWindows     5   	     � Title$!  SubscribedLibraryMainWindow��5   	   $	��450��6-   $	��800��6:   .��5	      � .+�5
   
   �� $
��Fill=�6�    �� StretchDirection$
 Both=�6�   $��/Images/LibraryImage.png��6�   $��61,0,0,0q�6�   ��6   �� *&$SystemParameters.PrimaryScreenHeight+��6I   �� *%#SystemParameters.PrimaryScreenWidth+6�   ]� 5   
   $��False��6   $��	0,0,739,0q�6*   .+�5      �� $
��Left=�6   
���   �$��3q�6?   $��63��6S   $	��431��6^   ._�5      �� -   5        $��6,226,0,151q�5      $
��Left=�6.   $��44��6I   ��5      �� 5       �� ImageSource$! /Images/LoanUtilityIcon.png��6%   6Q   5      5      5      �� 5   
   -   5        $
��Left=�5      $��49��6,   $��	10,54,0,0q�68   $	��Top=�6K   $��46��6c   ��5      �� 5      $  /Images/BookSearchIcon.png��6   6H   5      �� 5   
   -   5        $
��Left=�5      $��49��6,   $��
10,148,0,0q�68   $	��Top=�6L   $��42��6d   ��5      �� 5      $! /Images/UserProfileIcon.png��6   6I   5      �� 5    
   -   5        $
��Left=�5       $��
10,379,0,8q�6,   $��44��6@   ��5!      �� 5"      $ /Images/LogOut.png��6   6@   5$      �� 5%   
   $��Loan 
Book��6   $
��Left=�6.   $	��Top=�6I   $��61��6a   $��	0,192,0,0q�6l   �� 5&   
   $��User 
Profile��6   $
��Left=�61   $��	0,101,0,0q�6L   $	��Top=�6_   $��46��6w   �� 5'   
   $��Search 
Book��6   $
��Left=�60   $��0,12,0,0q�6K   $	��Top=�6]   $��53��6u   �� 5(   
   $��Log Out��6   $
��Left=�6"   $��	0,348,0,0q�6=   $	��Top=�6P   $��61��6h   �� 5)   
   $��	66,33,0,0q�6   .��5*      �  � ColumnDefinitions 5+      �� 5,      $	��105 �6'   �� 5-      $	��150 �6'   �� 5.      $	��150 �6'   �� 5/      $	��150 �6'   �� 50      $	��150 �6'    � RowDefinitions 53      �� 54      $��15 �6$   �� 55      $	��200 �6$   �� 56      $	��200 �6$   �� 57      $	��200 �6$   .+�59      � $��1��6   $��1��6$   $��10q�64   ��5:      �� 5;      $# /Images/BookTheDreamHotel.png��6%    j� Stretch$
 Fill=�6Q   5>      � 5?      $��1��6   $��2��6$   $��10q�64   ��5@      �� 5A      $  /Images/BookDreamCount.png��6%   $
 Fill=�6N   5D      � 5E      $��1��6   $��3��6$   $��10q�64   ��5F      �� 5G      $&  /Images/BookThisBookWillBury.png��6%   $
 Fill=�6T   5J      � 5K      $��1��6   $��4��6$   $��10q�64   ��5L      �� 5M      $# /Images/BookBufalloHunter.png��6%   $
 Fill=�6Q   5P      � 5Q      $��2��6   $��1��6$   $��10q�64   ��5R      �� 5S      $" /Images/BookFrankenstein.png��6%   $
 Fill=�6P   5V      � 5W      $��2��6   $��2��6$   $��10q�64   ��5X      �� 5Y      $' !/Images/BookTheFallOfThEHouse.png��6%   $
 Fill=�6U   5\      � 5]      $��2��6   $��3��6$   $��10q�64   ��5^      �� 5_      $+ %/Images/BookCollectedGhostStories.png��6%   $
 Fill=�6Y   5b      � 5c      $��2��6   $��4��6$   $��10q�64   ��5d      �� 5e      $! /Images/BookGothicTales.png��6%   $
 Fill=�6O   5h      � 5i      $��3��6   $��1��6$   $��10q�64   ��5j      �� 5k      $" /Images/BookCatchingFire.png��6%   $
 Fill=�6P   5n      � 5o      $��3��6   $��2��6$   $��10q�64   ��5p      �� 5q      $" /Images/BookOneWrongStep.png��6%   $
 Fill=�6P   5t      � 5u      $��3��6   $��3��6$   $��10q�64   ��5v      �� 5w      $$ /Images/BookSplinterEffect.png��6%   $
 Fill=�6R   5z      � 5{      $��3��6   $��4��6$   $��10q�64   ��5|      �� 5}      $$ /Images/BookWhatWakesBells.png��6%   $
 Fill=�6R   5�      5�      5�      �� 5�   
   $ ��List of new released Books��6   
���   �
�������$
��Left=�6[   $��
180,20,0,0q�6v   $	��Top=�6�   $	��253��6�   $��20(�6�   5�      5�      