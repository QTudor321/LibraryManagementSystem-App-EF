   M S B A M L   `   `   `  ����R  NLibraryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LibraryManagementSystem.LibraryLibraryManagementSystem.Library  5   	   1    +LibraryManagementSystem.Library.ManageUsers   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:LibraryManagementSystem.Library     5   	     � Title$  ManageUsers��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� $
��Left=�6   $	��409��6+   $��	10,10,0,0q�68   $	��Top=�6K   $	��771��6c   $��/Images/LibraryImage.png��6o   $
��Fill=�6�   �� 5   
   -   5        $��Add User��5      $
��Left=�6$   $��	68,74,0,0q�6?   $	��Top=�6R   6j   �� 5   
   -   5        $��Add Card��5      $
��Left=�6$   $��
270,74,0,0q�6?   $	��Top=�6S   6k   �� 5   
   -   5        $��Delete User��5      $
��Left=�6'   $��
450,74,0,0q�6B   $	��Top=�6V   6n   �� 5   
   -   5        $��Update Card Credit��5      $
��Left=�6.   $��
650,74,0,0q�6I   $	��Top=�6]   6u   �� 5   
   -   5        $&�� Update Users Subscription Status��5      $
��Left=�6<   $��
94,297,0,0q�6W   $	��Top=�6k   6�   � 5   
   -   5         �Name$ GridAddUser��5      $��68,131,587,142q�6$   $y�	Collapsed=�6<   .+�5      �� -   5         ��Name$ TxtUsernameAdd��5      $
��Left=�6.    �� TextWrapping$
 Wrap=�6I   $��Username��6]   $	��Top=�6m   $	��120��6�   �� 5      -   5        $ 
TxtLastAdd��5      $
��Left=�6*   $��0,18,0,0q�6E   $
 Wrap=�6W   $��LastName��6k   $	��Top=�6{   $	��120��6�   �� 5      -	   5        $ TxtFirstNameAdd��5      $
��Left=�6/   $��0,36,0,0q�6J   $
 Wrap=�6\   $��	FirstName��6p   $	��Top=�6�   $	��120��6�   �� 5      -
   5        $ TxtAddressAdd��5      $
��Left=�6-   $��0,54,0,0q�6H   $
 Wrap=�6Z   $��Address��6n   $	��Top=�6}   $	��120��6�   �� 5      -   5        $ TxtPasswordAdd��5      $
��Left=�6.   $��0,72,0,0q�6I   $
 Wrap=�6[   $��Password��6o   $	��Top=�6   $	��120��6�   �� 5      -   5        $ TxtStatusAdd��5      $
��Left=�6,   $��0,90,0,0q�6G   $
 Wrap=�6Y   $��SubscriptionStatus��6m   $	��Top=�6�   $	��120��6�   �� 5      -   5        $	��Add��5      $
��Left=�6#   $��
72,137,0,3q�6>   6R   �� 5      -   5        $ TxtLibByteAdd��5      $
��Left=�6-   $��	0,108,0,0q�6H   $
 Wrap=�6[   $��IsLibrarian��6o   $	��Top=�6�   $	��120��6�   5      � 5   
   -   5        $ GridAddCard��5      $��270,131,400,178q�6$   $y�	Collapsed=�6=   .+�5      �� -   5        $ TxtUserIDAddCard��5      $
��Left=�60   $
 Wrap=�6K   $��UserID��6_   $	��Top=�6m   $	��120��6�   �� 5      -   5        $ TxtCreditAddCard��5      $
��Left=�60   $��0,72,0,0q�6K   $
 Wrap=�6]   $��Credit��6q   $	��Top=�6   $	��120��6�   �� 5      -   5        $	��Add��5      $
��Left=�6#   $��	81,95,0,0q�6>   $	��Top=�6Q   6i   �� 5      -   5        $ TxtExpirationAddCard��5      $
��Left=�64   $��0,36,0,0q�6O   $
 Wrap=�6a   $��ExpirationDate��6u   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ TxtCVVAddCard��5      $
��Left=�6-   $��0,54,0,0q�6H   $
 Wrap=�6Z   $	��CVV��6n   $	��Top=�6y   $	��120��6�   �� 5       -   5        $ TxtNumberAddCard��5       $
��Left=�60   $
 Wrap=�6K   $��Number��6_   $	��Top=�6m   $	��120��6�   $��0,18,0,0q�6�   5"      � 5#   
   -   5        $ GridDeleteUser��5#      $��450,131,230,185q�6'   $y�	Collapsed=�6@   .+�5$      �� -   5        $ TxtUserIDDelete��5$      $��Center=�6/   $
 Wrap=�6L   $��UserID��6`   $	��Top=�6n   $	��120��6�   �� 5%      -   5        $��Delete��5%      $
��Left=�6&   $��
60,43,0,23q�6A   6U   5&      � 5'   
   -   5        $ GridUpdateCardCredit��5'      $��632,131,30,166q�6-   $y�	Collapsed=�6E   .+�5(      �� -   5        $ TxtCardIDUpdateCredit��5(      $��Center=�65   $
 Wrap=�6R   $��CardID��6f   $	��Top=�6t   $	��120��6�   �� 5)      -   5        $ TxtCardCreditUpdateCredit��5)      $��Center=�69   $��0,18,0,0q�6V   $
 Wrap=�6h   $��Credit��6|   $	��Top=�6�   $	��120��6�   �� 5*      -   5        $��Update��5*      $
��Left=�6&   $��	69,53,0,0q�6A   $	��Top=�6T   6l   5,      � 5-   
   -   5        $ GridUpdateStatus��5-      $��297,280,354,15q�6)   $y�	Collapsed=�6A   .+�5.      �� -   5        $ TxtUserIDStatus��5.      $
��Left=�6/   $��	10,10,0,0q�6J   $
 Wrap=�6]   $��UserID��6q   $	��Top=�6   $	��120��6�   �� 5/      -   5        $ TxtUserStatusStatus��5/      $
��Left=�63   $��	10,28,0,0q�6N   $
 Wrap=�6a   $��SubscriptionStatus��6u   $	��Top=�6�   $	��120��6�   �� 50      -    5        $��Update��50      $
��Left=�6&   $��	74,60,0,0q�6A   $	��Top=�6T   6l   52      �� 53   
   -!   5        $
��Menu��53      $
��Left=�6    $��670,340,0,0q�6;   $	��Top=�6P   6h   55      56      