   M S B A M L   `   `   `  ����[  WTworzenieAplikacjiBiznesowychATP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TworzenieAplikacjiBiznesowychATP TworzenieAplikacjiBiznesowychATP  5   	   ]3clr-namespace:TworzenieAplikacjiBiznesowychATP.View%TworzenieAplikacjiBiznesowychATP.View  5   	   1    +TworzenieAplikacjiBiznesowychATP.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:TworzenieAplikacjiBiznesowychATP     5   	   f bGalaSoft.MvvmLight.Platform, Version=5.2.0.37226, Culture=neutral, PublicKeyToken=5f873c45e98af8a1+mvvm http://www.galasoft.ch/mvvmlight  5   	   ?views3clr-namespace:TworzenieAplikacjiBiznesowychATP.View  5   	   T PMahApps.Metro, Version=1.2.4.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5
   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   ���	#FF537DD8 � DataContext 5   	   �� *Main+ �� Mode$ OneWay=�   Locator �� Source# [  (  "MahApps.Metro.Controls.MetroWindow   Flyouts 5      +  %MahApps.Metro.Controls.FlyoutsControl  5   
   .@�5      <   6TworzenieAplikacjiBiznesowychATP.View.AuthorFlyoutView  5         RightWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5         ��Name$ DisplayAuthorButton��5      $��Autor��62   $
��Left=�6B   $��
232,10,0,0q�5      $	��Top=�6&   $��75��6>    J� RenderTransformOrigin$ 0.511,0.416&�6o   ��6I   �� *OpenFlyoutCommand+6o   5      .��5      �� .@�5   
   �� $��Dodawanie pracownika��6   .��5      � .+�5      �� -   5        $ GreetingsButton��5      $��OK��62   $
��Left=�6?   $��211,163,0,0q�5      $	��Top=�6.   $��75��6F   ��6Q   �� *AddPersonCommand+�� 5      -   5         ��Name$ NameTextBlock��5      $
��Left=�63   $��
114,84,0,0q�6N   $
��Wrap=�6b   $��Podaj imię:��6v   $	��Top=�6�   �� 5      -   5        	 ��Name$	 NameTextBox��5      $
��Left=�6/   $��23��6J   $��114,118,0,0q�6V   
 �� TextWrapping$

 Wrap=�6k   $	��Top=�6�   $	��120��6�   ��6   �� *
PersonName+6�   �� 5      -   5        $ SurnameTextBlock��5      $
��Left=�66   $��
270,87,0,0q�6Q   $
��Wrap=�6e   $��Podaj nazwisko:��6y   $	��Top=�6�   �� 5       -   5        $	 SurnameTextBox��5       $
��Left=�62   $��23��6M   $��270,118,0,0q�6Y   $

 Wrap=�6n   $	��Top=�6�   $	��120��6�   ��6�   �� *PersonSurname+6�   5!      5"      �� 5#   
   $��Lista pracowników��6   .��5$      :   4TworzenieAplikacjiBiznesowychATP.View.PersonListView  5%      5&      5'      