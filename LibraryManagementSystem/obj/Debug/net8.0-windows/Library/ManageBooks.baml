   M S B A M L   `   `   `  ����R  NLibraryManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:LibraryManagementSystem.LibraryLibraryManagementSystem.Library  5   	   1    +LibraryManagementSystem.Library.ManageBooks   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ?local-clr-namespace:LibraryManagementSystem.Library     5   	     � Title$  ManageBooks��5   	   $	��450��6   $	��800��6*   .��5	      � .+�5
   
   �� $
��Left=�6   $	��409��6+   $��	10,10,0,0q�68   $	��Top=�6K   $	��771��6c   $��/Images/LibraryImage.png��6o   $
��Fill=�6�   � 5   
   -   5         �Name$ GridAddBook��5      $��68,106,587,167q�6$   $y�	Collapsed=�6<   .+�5      �� -   5         ��Name$ TxtBookTitleAdd��5      $
��Left=�6/   $��0,18,0,0q�6J    �� TextWrapping$
 Wrap=�6\   $��Title��6p   $	��Top=�6}   $	��120��6�   �� 5      -   5        $ TxtBookThemeAdd��5      $
��Left=�6/   $��0,36,0,0q�6J   $
 Wrap=�6\   $��Theme��6p   $	��Top=�6}   $	��120��6�   �� 5      -   5        $ TxtBookAuthorAdd��5      $
��Left=�60   $��0,54,0,0q�6K   $
 Wrap=�6]   $��Author��6q   $	��Top=�6   $	��120��6�   �� 5      -   5        $ TxtBookIdentifierAdd��5      $
��Left=�64   $��0,72,0,0q�6O   $
 Wrap=�6a   $��
Identifier��6u   $	��Top=�6�   $	��120��6�   �� 5      -   5        $ TxtBookCopiesAdd��5      $
��Left=�60   $��0,90,0,0q�6K   $
 Wrap=�6]   $��Copies��6q   $	��Top=�6   $	��120��6�   �� 5      -   5        $	��Add��5      $
��Left=�6#   $��
94,131,0,0q�6>   $	��Top=�6R   6j   �� 5      -   5        $ TxtBookPriceAdd��5      $
��Left=�6/   $��	0,108,0,0q�6J   $
 Wrap=�6]   $��Price��6q   $	��Top=�6~   $	��120��6�   5      �� 5   
   -	   5        $��Add Book��5      $
��Left=�6$   $��	68,81,0,0q�6?   $	��Top=�6R   6j   � 5   
   -
   5        $ GridUpdatePrice��5      $��270,131,400,235q�6(   $y�	Collapsed=�6A   .+�5      �� -   5        $ TxtBookIDUpdatePrice��5      $
��Left=�64   $
 Wrap=�6O   $��bookID��6c   $	��Top=�6q   $	��120��6�   �� 5      -   5        $ TxtPriceUpdatePrice��5      $
��Left=�63   $��0,18,0,0q�6N   $
 Wrap=�6`   $��Price��6t   $	��Top=�6�   $	��120��6�   �� 5      -   5        $��Update��5      $
��Left=�6&   $��	80,41,0,7q�6A   6T   5      �� 5   
   -   5        $��Update Price��5      $
��Left=�6(   $��
270,81,0,0q�6C   $	��Top=�6W   6o   � 5   
   -   5        $ GridDeleteBook��5      $��450,131,230,217q�6'   $y�	Collapsed=�6@   .+�5      �� -   5        $ TxtBookIDDelete��5      $��Center=�6/   $
 Wrap=�6L   $��bookID��6`   $	��Top=�6n   $	��120��6�   �� 5       -   5        $��Delete��5       $
��Left=�6&   $��
60,43,0,23q�6A   6U   5!      �� 5"   
   -   5        $��Delete Book��5"      $
��Left=�6'   $��
450,81,0,0q�6B   $	��Top=�6V   6n   � 5#   
   -   5        $ GridUpdateCopy��5#      $��632,131,30,220q�6'   $y�	Collapsed=�6?   .+�5$      �� -   5        $ TxtBookIDUpdateCopy��5$      $��Center=�63   $
 Wrap=�6P   $��bookID��6d   $	��Top=�6r   $	��120��6�   �� 5%      -   5        $ TxtCopiesUpdateCopy��5%      $��Center=�63   $��0,18,0,0q�6P   $
 Wrap=�6b   $��Copies��6v   $	��Top=�6�   $	��120��6�   �� 5&      -   5        $��Update��5&      $
��Left=�6&   $��	69,53,0,0q�6A   $	��Top=�6T   6l   5(      �� 5)   
   -   5        $��Update Copies��5)      $
��Left=�6)   $��
632,81,0,0q�6D   $	��Top=�6X   6p   �� 5*   
   -   5        $
��Menu��5*      $
��Left=�6    $��667,373,0,0q�6;   $	��Top=�6P   6h   5,      5-      