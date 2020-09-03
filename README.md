<p align="center">
  <img src="https://github.com/Arpha01/WaktuShalat/blob/master/WaktuShalat/Resources/WaktuShalat_logo.png" height="auto" width="256px">
</p>

<h1 align="center">WaktuShalat</h1>

<p align="center">
  <a href="#">
    <img src="https://img.shields.io/badge/contributions-welcome-green">
  </a>
  <a href="https://github.com/Arpha01/WaktuShalat/issues">
    <img src="https://img.shields.io/github/issues/Arpha01/WaktuShalat?style=flat-square">
  </a>
  <a href="https://github.com/Arpha01/WaktuShalat/stargazers">
    <img src="https://img.shields.io/github/stars/Arpha01/WaktuShalat?style=flat-square">
  </a>
  <a href="https://github.com/Arpha01/WaktuShalat/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/Arpha01/WaktuShalat?style=flat-square">
  </a>
</p>

<p align="center">
  WaktuShalat adalah sebuah Aplikasi opensource yang berfungsi sebagai sarana pengingat untuk menjalankan ibadah. Dibangun menggunakan bahasa C# dan Fathimah Engine. 
  Semua data shalat bersumber dari <i>Departemen Agama Republik Indonesia</i>
</p>

## Support
WaktuShalat mendukung 511 Kota di Indonesia. Dan untuk saat ini hanya mendukung region Indonesia saja

## Build Instructions
WaktuShalat reverse geocoding engine menggunakan Bing Maps milik Microsoft
<ol>
     <li>Pertama, Kamu perlu mendapatkan Bing Maps API Key Kamu sendiri di Bing Maps Dev Center <a href="https://www.bingmapsportal.com/">Daftar Di Sini</a></li>
     <li>Instal Visual Studio Community 2019. <a href="https://arpha01.blogspot.com/2019/09/1-visual-basic-net-tutorial-menginstall.html">Panduan Instalasi!</a></li>
     <li>Di LocationController.cs dalam string key Kamu perlu mengganti ``` File.ReadAllText ("key.txt") ``` dengan kunci bing maps Kamu sendiri <br></li>
     <li>Instal semua NuGet dependency menggunakan Package manager console ``` nuget install packages.config ``` </li>
     <li>Tekan F5 untuk memulai</li>
</ol>

## Requirements
Minimum Windows 8.1 / Windows 10 32Bit maupun 64Bit

<i>Not tested in Windows 7</i>

## License
The MIT License (MIT)

Copyright © 2020 [ArphaInteractive](https://arpha01.github.io)
