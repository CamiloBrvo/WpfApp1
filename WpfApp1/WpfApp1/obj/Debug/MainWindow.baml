   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��8* �6   �� 5      $	��55* �6   �� 5      $	��34* �6   �� 5      $	��68* �6   �� 5      $
��627* �6   .+�5   
   �� -   5        $��	Connexion��5      $
��Left=�6%   $��150,307,0,0q�6@   $	��Top=�6U   $	��157��6m   4  .System.Windows.Automation.AutomationProperties   Name$ btnConnexion��6y   $��29��6�    J� RenderTransformOrigin$ 0.812,0.387&�6�   $��4��6�   �� 5   
   $��Identifiant : ��6   $
��Left=�6)   $��
68,151,0,0q�6D   $	��Top=�6X   $ lblIdentifiant��6p   $��4��6�   �� 5   
   $��Mot de passe : ��6   $
��Left=�6*   $��
50,207,0,0q�6E   $	��Top=�6Y   $ lblMotDePasse��6q   $��4��6�   �� 5   
   -   5         ��Name$ txbIdentifiant_GUI��5      $
��Left=�6.   $��23��6I   $��175,155,0,0q�6U    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��120��6�   $ txbIdentifiant_GUI��6�   $��4��6�   �� 5   
   -   5        $ txbMotDePasse_GUI��5      $
��Left=�6-   $��23��6H   $��175,211,0,0q�6T   $
 Wrap=�6i   $	��Top=�6}   $	��120��6�   $ txbMotDePasse_GUI��6�   $��4��6�   6  �� 5   
   $��
Page Login��6   $��4��6%   $
��Left=�65   $��
175,49,0,0q�6P   $	��Top=�6d   $��20(�6|   $	��120��6�   5      5      