   M S B A M L   `   `   `  ����D  @Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Documents.ViewModelsDocuments.ViewModels  5      #    Documents.Views.DocumentsHome   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1vm"clr-namespace:Documents.ViewModels     5        N� Title$  Documents - Home��5	       � DataContext 5      1   +Documents.ViewModels.DocumentsHomeViewModel  5   
   .��5      � $��-21,-10,21,10q�6   .+�5   
   �� $
��Left=�6   $	��280��60   $��
165,10,0,0q�6=   $	��Top=�6Q   $	��425��6i   .+�5      �� -   5         ��Name$ label��5      $��Label��6#   $
��Left=�63   $��24��6N   $	��235��6Z   �� 5      -   5         ��Name$ textBox��5      $
��Left=�6'   $��25��6B    �� TextWrapping$
 Wrap=�6N   $��TextBox��6b   $	��235��6q    6}   �� *SelectedPerson.Name+�� 5      -   5        $ label1��5      $��Label��6$   $
��Left=�64   $��24��6O   $	��235��6[   �� 5      -   5        $ textBox1��5      $
��Left=�6(   $��25��6C   $
 Wrap=�6O   $��TextBox��6c   $	��235��6r    6~   �� *SelectedPerson.Job+�� 5      -   5         ��Name$ button1��5      $��Button��6&   $
��Left=�67   $��25��6R   $	��136��6^   $��0,25,0,0q�6j   �� 5      -   5        $ button1_Copy��5      $��Button��6+   $
��Left=�6<   $��25��6W   $	��136��6c   $��0,25,0,0q�6o   5      �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $	��233��6>   $��19,8,0,0q�6K   $	��Top=�6]   $	��141��6u   ��6�   �� *People+��6�   �� *Name+�� 5   
   -   5        $ 	addPerson��5      $	��Add��6<   $
��Left=�6J   $��44��6e   $��
19,246,0,0q�6q   $	��Top=�6�   $	��141��6�   5      5      