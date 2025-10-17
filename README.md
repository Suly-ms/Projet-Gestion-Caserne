# 🚒 Projet Gestion Caserne

Une application **Windows Forms** en **C#** permettant de gérer une caserne de pompiers : interventions, véhicules, pompiers, et habilitations.  

---

## 🔥 Présentation

Le **Projet Gestion Caserne** a pour but de modéliser la gestion opérationnelle d’une caserne de pompiers.  
L’application permet de manipuler des données telles que :
- Les pompiers et leurs habilitations  
- Les véhicules disponibles  
- Les interventions et leur attribution  
- Les ressources mobilisées pour chaque intervention  

L’interface graphique en **WinForms** rend l’usage intuitif et adapté à un environnement de gestion interne.

---

## 🧠 Fonctionnalités

- 👨‍🚒 **Gestion des pompiers** (ajout, modification, suppression)
- 🚒 **Gestion des véhicules** selon leur disponibilité et type
- ⚠️ **Gestion des interventions** : type, localisation, ressources nécessaires
- 🧾 **Sélection automatique** des pompiers et véhicules selon les habilitations requises
- 🔍 **Recherche et filtrage** dans les listes
- 💾 **Sauvegarde des données** via un `DataSet` local

---

## 🏗️ Architecture & technologies

- **Langage :** C#  
- **Framework :** .NET (Windows Forms)  
- **Données :** `DataSet` et fichiers XML  
- **IDE recommandé :** Visual Studio  
- **Patrons utilisés :** séparation entre couches UI / logique / données  

---

## ⚙️ Installation & configuration

### 1. Prérequis
- Windows  
- Visual Studio (avec le workload `.NET desktop development`)  

### 2. Cloner le dépôt
```bash
git clone https://github.com/Suly-ms/Projet-Gestion-Caserne.git
