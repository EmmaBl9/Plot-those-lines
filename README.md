# Plot-those-lines

## Introduction

Concevoir un logiciel permettant d'afficher des graphiques à partir de données structurées.

---

## Objectifs produit et pédagogiques

L'objectif du projet est de développer une application web interactive permettant de charger, traiter et afficher des séries temporelles issues de fichiers de données.

Sur le plan pédagogique, ce projet vise à développer et renforcer les compétences suivantes :

- Manipulation et filtrage de données : utilisation de LINQ pour traiter efficacement les séries temporelles
- Organisation du code (namespace, classes, commit log,…)
- Code compact et réutilisable (pas de copié-collé)
- Optimisation (utilisation de structures adaptées)
- Qualité et fiabilité (avec des tests unitaires)
- Documentation et lisibilité (commenter le code)
- Complétude du projet (code, modèle de données, maquettes PDF, éxécutable, …)

---

## Description du domaine

Le domaine choisi est la **démographie suisse**.

Les données utilisées proviennent du site officiel de l'Office fédéral de la statistique : [https://www.bfs.admin.ch/bfs/de/home.html](https://www.bfs.admin.ch/bfs/de/home.html)

Ces données ont été téléchargées sous forme de fichiers CSV, puis importées dans l'application afin d'être affichées sous forme de courbes temporelles.

---

## Planification

La planification du projet a été effectuée à l'aide de **GitHub Projects**, accessible dans le dépôt GitHub du projet.

---

## Fonctionnalités principales

- Import de fichiers CSV contenant des séries temporelles
- Affichage simultané de plusieurs séries de données sur un même graphique
- Choix de la couleur pour chaque série
- Filtrage par intervalle de dates via un service DateFilter
- Suppression dynamique de fichiers importés
- Affichage automatique des statistiques (Min / Max / Moyenne)
- Rendu graphique avec ApexCharts intégré à Blazor

---

## Rapport de tests

### Tests unitaires

| Test ID | Description | Résultat attendu | Résultat obtenu |
|---------|-------------|------------------|-----------------|
| Extension 1 | Arrondir à 2 un nombre positif (RoundTo2) | Valeur arrondie correctement | OK |
| Extension 2 | Arrondir à 2 un nombre négatif (RoundTo2) | Valeur arrondie correctement | OK |
| Extension 3 | Vérifier si la donnée est vide (IsEmpty) | Retourne `true` si vide | OK |

### Tests globaux du projet

| Test ID | Description | Résultat attendu | Résultat obtenu |
|---------|-------------|------------------|-----------------|
| Test 1 | Tester le filtre (`setDateRange`) | Le filtre s'applique correctement | OK |
| Test 2 | Tester le nettoyage du filtre (`clearFilter`) | Le filtre est réinitialisé | OK |

### Tests manuels

| Test ID | Description | Résultat attendu | Résultat obtenu |
|---------|-------------|------------------|-----------------|
| Test 1 | Vérifier l'affichage du graphique avec des données valides | Le graphique s'affiche correctement | OK |
| Test 2 | Supprimer un fichier et actualiser le graphique | Le graphique se met à jour sans erreur | OK |

---

## Journal de travail

Le journal de travail est disponible à la racine du dépôt : **`Journal-de-travail_EmmaBlanchoud.xlsx`**

---

## Usage de l'IA dans ce projet

J'ai utilisé l'intelligence artificielle pour m'aider à comprendre et gérer les erreurs liées à l'utilisation de la bibliothèque ApexCharts, que je découvrais pour la première fois. 
L'IA m'a permis de : 
- Trouver des exemples d'implémentation adaptés à Blazor
- Corriger certaines erreurs de syntaxe
- Comprendre la logique du rendu graphique avec le framework

---

## Conclusion / Bilan

J'ai beaucoup apprécié ce projet, qui m'a permis de découvrir et d'approfondir **Blazor**.

L'apprentissage de cette technologie a été un défi, mais j'ai trouvé le framework intuitif.

Les principales difficultés ont concerné **ApexCharts** et le rendu graphique, mais cela m'a aidée à mieux comprendre le débogage et l'organisation du code.

### Points d'amélioration pour un prochain projet :

- Prendre plus de temps pour étudier les bibliothèques graphiques avant l'implémentation
- Mieux planifier la gestion du temps durant l'analyse du projet

Je suis satisfaite du résultat et confiante dans ma capacité à réutiliser ces technologies à l'avenir.
