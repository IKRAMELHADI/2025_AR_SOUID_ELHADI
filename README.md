# Jeu Antiaérien en Réalité Augmentée avec Unity

##  Présentation du projet

Ce projet a été réalisé dans le cadre d’un module de Réalité Augmentée à l’ENSIM (École Nationale Supérieure d'Ingénieurs du Mans) durant l’année universitaire 2024-2025.

Nous avons développé un jeu mobile interactif en Réalité Augmentée (AR), utilisant **Unity** et **AR Foundation**, dans lequel le joueur place une tourelle antiaérienne virtuelle dans son environnement réel. Le but du jeu est de **détruire 10 avions en moins de 60 secondes** en tirant sur eux via l’écran tactile.

---

##  Objectifs du jeu

-  Scanner une surface plane avec la caméra
-  Placer une tourelle virtuelle dans l’environnement réel
-  Appuyer sur "Start" pour lancer une session de 60 secondes
-  Tirer sur les avions ennemis qui apparaissent en vol
-  Gagner en abattant 10 avions avant la fin du chrono

Le joueur voit son **score en temps réel** ainsi qu’un **message de fin** ("gagné" ou "perdu") à l’issue de chaque session.

---

##  Fonctionnalités implémentées

-  Détection de surface plane via AR Foundation (placement de la tourelle)
-  Apparition animée et aléatoire d'avions ennemis
-  Interaction tactile simple pour tirer
-  Système de détection de collision entre tir et avion
-  Affichage dynamique du score et du chrono
-  Boucle de jeu rejouable et rapide à comprendre

---

##  Technologies utilisées

| Composant         | Détail                                     |
|-------------------|--------------------------------------------|
|  Moteur de jeu    | Unity 2022.3 LTS                           |
|  AR Framework     | AR Foundation 5.1                          |
|  Plateforme cible | Android avec ARCore (minimum Android 9)    |
|  Langage          | C#                                         |
|  Assets           | Unity Asset Store (modèles d’avions, UI)   |
|  Versioning       | Git & GitHub                               |

---

##  Références et documentation

- [Unity AR Foundation Docs](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@latest)
- [Tutoriel Brackeys - AR Foundation](https://www.youtube.com/watch?v=6dVlf7Q0t4c)
- [Documentation C# Microsoft](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [Unity Asset Store](https://assetstore.unity.com/)
- Azuma, R.T. (1997). *A Survey of Augmented Reality*. Presence: Teleoperators and Virtual Environments.

---

##  Auteurs

- **Mohammed Amine SOUID**
- **Ikram EL HADI**

**Encadrant** : Emmanuel Blanchard  
**Établissement** : ENSIM – Le Mans Université  
**Année universitaire** : 2024-2025

---

##  Remarques finales

Ce projet nous a permis de :
- Maîtriser la détection de surfaces AR
- Créer une expérience interactive et immersive
- Gérer des interactions en temps réel via Unity et C#
- Apprendre à structurer un jeu complet avec des contraintes de performance
- Travailler efficacement en binôme sur un projet technique et ludique

=> Le projet offre une base solide pour de futures évolutions : niveaux de difficulté, effets sonores, leaderboard en ligne, ou portage vers iOS via ARKit.

