   M S B A M L   `   `   `  ����I  ELibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:LibraryProject.ViewsLibraryProject.Views  5   	   %    LibraryProject.Views.ObjectInfo   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:LibraryProject.Views     5   	     � Title$  
ObjectInfo��5   	   $	��450��6   $	��250��6)   .��5	      � 
����·� � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$ 
tbItemName��5      $��0��6(   $��0��65   $��4��6E   $��Center=�6Y   $��Center=�6t   $��WrapWithOverflow=�6�   
����+��6�   �� 5   
   -   5        $ tbItemPrice��5      $��1��6)   $��1��69   $��Center=�6F   $��Center=�6a   
����+��$��WrapWithOverflow=�6�   6�   �� 5   
   -   5        $ tbType��5      $��2��6$   $��1��64   $��Center=�6A   $��Center=�6\   
����+��$��WrapWithOverflow=�6�   6�   �� 5   
   -   5         ��Name$ DeleteButton��5      $��Delete��6'   $��1��68   $��5��6H   $��20��6U   $��50��6a   6l   �� 5   
   -   5        $ UpdateButton��5      $��Update��6'   $��2��68   $��5��6H   $��20��6U   $��50��6a   6l   �� 5   
   $��
Edit Here:��6   $��1��6&   $��2��66   $��2��6C   $��Bottom=�6W   $��Center=�6r   �� 5   
   $��3��6   $	��Top=�6!   $��Title:��69   �� 5   
   $��Price��6   $��3��6!   $��1��6.   $	��Top=�6>   �� 5    
   -   5         ��Name$ tbEditPrice��5       $��3��6'   $��1��64   $��50��6D   $��20��6O   �� 5!   
   -   5        $ 
tbEditName��5!      $��3��6&   $��50��63   $��20��6>   �� 5"   
   $��1��6   $��4��6$   $.��(Invalid price value will be set to zero.��61   $��WrapWithOverflow=�6a   $��10(�6�   �� 5#   
   -   5        $ tbISBNEditTitle��5#      $��4��6-   $��0��6:   $	��Top=�6J   $��ISBN: (Books)��6b   $��WrapWithOverflow=�6w   $y�Hidden=�6�   �� 5$   
   -	   5        $ tbISBNEditInput��5$      $��50��6+   $��20��66   $��0��6B   $��4��6R   $��Bottom=�6_   $y�Hidden=�6z   �� 5%   
   -
   5        $ tbMonthEditTitle��5%      $��4��6.   $��0��6;   $	��Top=�6K   $��Months: (Journals)��6c   $��WrapWithOverflow=�6}   $y�Hidden=�6�   �� 5&   
   -   5        $��cbMonthsEditInput��5&      $��60��6,   $��20��67   $��0��6C   $��4��6S   $��Bottom=�6`   $y�Hidden=�6{   5'      5(      