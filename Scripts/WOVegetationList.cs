﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DaggerfallWorkshop.Utility;

namespace WildernessOverhaul
{
    public class WOVegetationList
    {
        public List<int> temperateWoodlandFlowers, temperateWoodlandMushroom, temperateWoodlandBushes, temperateWoodlandRocks, temperateWoodlandTrees, temperateWoodlandDeadTrees, temperateWoodlandBeach;
        public List<int> woodlandHillsFlowers, woodlandHillsBushes, woodlandHillsRocks, woodlandHillsTrees, woodlandHillsNeedleTrees, woodlandHillsDeadTrees, woodlandHillsDirtPlants, woodlandHillsBeach;
        public List<int> mountainsFlowers, mountainsGrass, mountainsRocks, mountainsTrees, mountainsNeedleTrees, mountainsDeadTrees, mountainsBeach;
        public List<int> desertFlowers, desertWaterFlowers, desertPlants, desertWaterPlants, desertStones, desertTrees, desertCactus, desertDeadTrees;
        public List<int> hauntedWoodlandFlowers, hauntedWoodlandMushroom, hauntedWoodlandBones, hauntedWoodlandPlants, hauntedWoodlandBushes, hauntedWoodlandRocks, hauntedWoodlandTrees, hauntedWoodlandDirtTrees, hauntedWoodlandDeadTrees, hauntedWoodlandBeach;
        public List<int> rainforestFlowers, rainforestEggs, rainforestPlants, rainforestBushes, rainforestRocks, rainforestTrees, rainforestBeach;

        public List<int> collectionTemperateWoodlandFlowers = new List<int>(new int[] {2, 21, 22});
        public List<int> collectionTemperateWoodlandMushroom = new List<int>(new int[] { 7, 9, 23 });
        public List<int> collectionTemperateWoodlandBushes = new List<int>(new int[] { 1, 27, 28 });
        public List<int> collectionTemperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });
        public List<int> collectionTemperateWoodlandTrees = new List<int>(new int[] { 11, 12, 13, 14, 15, 16, 17, 18 });
        public List<int> collectionTemperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 29, 30, 31 });
        public List<int> collectionTemperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });

        public List<int> collectionWoodlandHillsFlowers = new List<int>(new int[] { 2, 7, 21, 22 });
        public List<int> collectionWoodlandHillsBushes = new List<int>(new int[] { 9, 27, 31 });
        public List<int> collectionWoodlandHillsRocks = new List<int>(new int[] { 1, 3, 4, 6, 8, 10, 17, 18, 28 });
        public List<int> collectionWoodlandHillsTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 25, 30 });
        public List<int> collectionWoodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 30 });
        public List<int> collectionWoodlandHillsDeadTrees = new List<int>(new int[] { 19, 20, 24 });
        public List<int> collectionWoodlandHillsDirtPlants = new List<int>(new int[] { 23, 26, 29 });
        public List<int> collectionWoodlandHillsBeach = new List<int>(new int[] { 26, 29, 31 });

        public List<int> collectionMountainsFlowers = new List<int>(new int[] { 22 });
        public List<int> collectionMountainsGrass = new List<int>(new int[] { 2, 7, 9, 23 });
        public List<int> collectionMountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 8, 10, 14, 17, 18, 27, 28, 31 });
        public List<int> collectionMountainsTrees = new List<int>(new int[] { 5, 11, 12, 13, 15, 21, 25, 30 });
        public List<int> collectionMountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 30, 12, 25, 30 });
        public List<int> collectionMountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 26, 29 });
        public List<int> collectionMountainsBeach = new List<int>(new int[] { 8, 26, 29, 2, 7, 7, 7, 23, 23 });

        public List<int> collectionDesertFlowers = new List<int>(new int[] { 9, 9, 9, 17, 24, 24, 24, 26, 26, 31, 31, 31 });
        public List<int> collectionDesertWaterFlowers = new List<int>(new int[] { 7, 17, 24, 24, 29, 29 });
        public List<int> collectionDesertPlants = new List<int>(new int[] { 7, 25, 27 });
        public List<int> collectionDesertWaterPlants = new List<int>(new int[] { 7, 7, 7, 7, 7, 25, 27, 27, 27, 27, 27 });
        public List<int> collectionDesertStones = new List<int>(new int[] { 2, 3, 4, 6, 8, 18, 19, 20, 21, 22, });
        public List<int> collectionDesertTrees = new List<int>(new int[] { 5, 13, 13 });
        public List<int> collectionDesertCactus = new List<int>(new int[] { 1, 14, 15, 16 });
        public List<int> collectionDesertDeadTrees = new List<int>(new int[] { 10, 11, 12, 23, 28 });

        public List<int> collectionHauntedWoodlandFlowers = new List<int>(new int[] { 21 });
        public List<int> collectionHauntedWoodlandMushroom = new List<int>(new int[] { 22, 23 });
        public List<int> collectionHauntedWoodlandBones = new List<int>(new int[] { 11 });
        public List<int> collectionHauntedWoodlandPlants = new List<int>(new int[] { 7, 14, 17, 29, 31 });
        public List<int> collectionHauntedWoodlandBushes = new List<int>(new int[] { 2, 26, 27, 28 });
        public List<int> collectionHauntedWoodlandRocks = new List<int>(new int[] { 1, 3, 4, 5, 6, 8, 10, 12 });
        public List<int> collectionHauntedWoodlandTrees = new List<int>(new int[] { 13, 13, 13, 15 });
        public List<int> collectionHauntedWoodlandDirtTrees = new List<int>(new int[] { 18, 19, 20, 31 });
        public List<int> collectionHauntedWoodlandDeadTrees = new List<int>(new int[] { 16, 18, 24, 25, 30, 31 });
        public List<int> collectionHauntedWoodlandBeach = new List<int>(new int[] { 31, 8, 9, 14, 29, 31 });

        public List<int> collectionRainforestFlowers = new List<int>(new int[] { 6, 20, 21, 22, 26, 27 });
        public List<int> collectionRainforestEggs = new List<int>(new int[] { 28, 29, 31 });
        public List<int> collectionRainforestPlants = new List<int>(new int[] { 2, 5, 10, 11, 23, 24 });
        public List<int> collectionRainforestBushes = new List<int>(new int[] { 3, 9, 16, 18 });
        public List<int> collectionRainforestRocks = new List<int>(new int[] { 1, 4, 17, 19, 25 });
        public List<int> collectionRainforestTrees = new List<int>(new int[] { 12, 13, 14, 15, 30 });
        public List<int> collectionRainforestBeach = new List<int>(new int[] { });

        public List<float> elevationLevels;

        public WOVegetationList(float elevation, DaggerfallDateTime.Seasons season, float mapStyle) {

            elevationLevels = new List<float>(new float[] {
                Random.Range(0.66f,0.64f), Random.Range(0.61f,0.59f), Random.Range(0.56f,0.54f),
                Random.Range(0.51f,0.49f), Random.Range(0.46f,0.44f), Random.Range(0.41f,0.39f),
                Random.Range(0.36f, 0.34f), Random.Range(0.31f,0.29f), Random.Range(0.26f,0.24f),
                Random.Range(0.21f,0.19f), Random.Range(0.11f,0.09f), Random.Range(0.076f,0.74f),
                Random.Range(0.051f,0.049f), Random.Range(0.021f,0.019f)});

            if (elevation > elevationLevels[0])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29 });
                    mountainsNeedleTrees = new List<int>(new int[] { 11, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 7, 9, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22 });
                    mountainsNeedleTrees = new List<int>(new int[] { 12, 25, 30, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 2, 7, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }

            else if (elevation <= elevationLevels[0] && elevation > elevationLevels[1])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 29, 29, 29, 29, 29, 29, 29, 11, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 11, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 7, 9, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 12, 25, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 12, 25, 30, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 2, 7, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[1] && elevation > elevationLevels[2])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 29, 29, 29, 29, 11, 25, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 11, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 7, 9, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 12, 12, 25, 25, 30, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 12, 25, 30, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 2, 7, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[2] && elevation > elevationLevels[3])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 29, 29, 29, 29, 11, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 11, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 7, 9, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 22, 22, 22, 22, 22, 12, 12, 25, 25, 30, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 12, 25, 30, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 2, 7, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[3] && elevation > elevationLevels[4])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 29, 29, 5, 11, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 11, 25, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 7, 9, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 22, 22, 22, 22, 5, 11, 12, 12, 25, 25, 30, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 30, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 2, 7, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[4] && elevation > elevationLevels[5])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 29, 29, 5, 11, 13, 21, 25, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 11, 25, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 9, 23, 23, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 22, 22, 5, 11, 12, 13, 21, 25, 25, 30, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 12, 25, 25, 30, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 7, 9, 9, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[5] && elevation > elevationLevels[6])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 5, 11, 11, 13, 21, 25, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 11, 25, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 9, 23, 23, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 22, 5, 11, 12, 13, 21, 25, 25, 30, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 12, 25, 25, 30, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 7, 9, 9, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[6] && elevation > elevationLevels[7])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 29, 5, 11, 11, 13, 21, 25, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 11, 25, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 9, 23, 23, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 23, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 22, 5, 11, 12, 13, 21, 25, 25, 30, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 12, 25, 25, 30, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 7, 9, 9, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 31 });
                }
            }
            else if (elevation <= elevationLevels[7] && elevation > elevationLevels[8])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 29, 5, 11, 11, 13, 21, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 11, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 9, 23, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 26, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 14, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 22, 5, 11, 12, 13, 21, 25, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 7, 9, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 22, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 14, 15, 25, 30 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7, 31 });
                }
            }
            else if (elevation <= elevationLevels[8] && elevation > elevationLevels[9])
            {
                temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 15, 17, 18, 25, 25, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 29, 5, 11, 11, 13, 24, 21, 25, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 11, 25, 25, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 30, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 7, 9, 23, 23, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 21, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 13, 14, 14, 16, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 22, 5, 11, 12, 13, 15, 21, 25, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 30, 12, 25, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 24, 26, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 2, 7, 9, 9, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 21, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 5, 11, 12, 12, 13, 13, 14, 14, 16, 25, 12 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7, 31 });
                }
            }
            else if (elevation <= elevationLevels[9] && elevation > elevationLevels[10])
            {
                float rnd = mapStyle + Random.Range(-10f,10f);
                if (rnd <= 30) // Conifere forest 1
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 13, 25, 25, 25});
                if (rnd > 30) // Mischwald 1
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 25});
                if (rnd > 35) // Laubwald
                    temperateWoodlandTrees = new List<int>(new int[] { 17, 18});
                if (rnd > 41) // Conifere forest 2
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 13, 13, 25, 25});
                if (rnd > 47) // Birkenwald
                    temperateWoodlandTrees = new List<int>(new int[] { 11, 14, 14, 14, 15, 15});
                if (rnd > 55) // Oak forest
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 17, 18, 18, 18});
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 1, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 13, 13, 24, 24, 24, 21, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 30, 30, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 9, 9, 23, 26, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 21, 21, 21, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 23, 27, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 12, 12, 13, 14, 14, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 13, 13, 15, 15, 15, 21, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 12, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 26, 26, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 7, 7, 9, 23, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 21, 21, 21, 22, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 9, 27, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 12, 12, 13, 14, 15, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7, 31 });
                }
            }
            else if (elevation <= elevationLevels[10] && elevation > elevationLevels[11])
            {
                float rnd = mapStyle + Random.Range(-10f,10f);
                if (rnd <= 30) // Conifere forest
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 13, 25, 25, 25});
                if (rnd > 30) // Mischwald 1
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 14, 16, 17});
                if (rnd > 35) // Laubwald
                    temperateWoodlandTrees = new List<int>(new int[] { 16, 17, 18});
                if (rnd > 41) // Mischwald 2
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 15, 18});
                if (rnd > 47) // Birkenwald
                    temperateWoodlandTrees = new List<int>(new int[] { 11, 14, 14, 14, 15, 15});
                if (rnd > 55) // Oak forest
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 17, 17, 18, 18, 18});

                temperateWoodlandTrees = new List<int>(new int[] { 13, 13, 14, 14, 15, 17, 18, 25 });
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 26, 27, 27, 28, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 13, 13, 24, 24, 24, 21, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 11, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 30, 30, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 9, 9, 23, 26, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 21, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 31 });
                    woodlandHillsTrees = new List<int>(new int[] { 12, 12, 13, 13, 14, 14, 14, 16, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 12, 25, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 13, 13, 15, 15, 15, 21, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 12, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 26, 26, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 7, 7, 9, 23, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 21, 22 });
                    woodlandHillsBushes = new List<int>(new int[] { 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 12, 12, 13, 13, 14, 14, 15, 15, 16, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 12, 25, 30 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7, 31 });
                }
            }
            else if (elevation <= elevationLevels[11] && elevation > elevationLevels[12])
            {
                float rnd = mapStyle + Random.Range(-10f,10f);
                if (rnd <= 30) // Mischwald
                    temperateWoodlandTrees = new List<int>(new int[] { 11, 12, 13, 14, 15, 16, 17, 18});
                if (rnd > 30) // Beach forest 1
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 12, 12, 16, 16, 17});
                if (rnd > 35) // Beach forest 2
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 16, 16, 16, 17, 17});
                if (rnd > 41) // Birkenwald 1
                    temperateWoodlandTrees = new List<int>(new int[] { 14, 14, 14, 15, 15});
                if (rnd > 47) // Birkenwald 2
                    temperateWoodlandTrees = new List<int>(new int[] { 14, 14, 15, 15, 15});
                if (rnd > 55) // Laubwald
                    temperateWoodlandTrees = new List<int>(new int[] { 16, 17, 18});

                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 25, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 2, 21, 21, 21, 22, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 7, 7, 9, 23, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 1, 26, 27, 27, 28, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 13, 13, 24, 24, 24, 21, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 30, 30, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 9, 9, 23, 26, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 21, 21, 21 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 27 });
                    woodlandHillsTrees = new List<int>(new int[] { 12, 13, 13, 13, 14, 14, 14, 16, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9, 31 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 13, 13, 15, 15, 15, 21, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 12, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 26, 26, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 7, 7, 9, 23, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 21, 21, 21 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 27, 31 });
                    woodlandHillsTrees = new List<int>(new int[] { 12, 13, 13, 13, 14, 14, 15, 15, 16, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7 });
                }
            }
            else if (elevation <= elevationLevels[12] && elevation > elevationLevels[13])
            {
                float rnd = mapStyle + Random.Range(-10f,10f);
                if (rnd <= 30) // Birkenwald
                    temperateWoodlandTrees = new List<int>(new int[] { 14, 14, 14, 15, 15});
                if (rnd > 30) // Oak forest
                    temperateWoodlandTrees = new List<int>(new int[] { 13, 17, 17, 18, 18, 18});
                if (rnd > 35) // Laubwald
                    temperateWoodlandTrees = new List<int>(new int[] { 16, 17, 18});
                if (rnd > 41) // Beach forest 1
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 12, 12, 16, 17});
                if (rnd > 47) // Beach forest 2
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 16, 17, 17, 17});
                if (rnd > 55) // Beach forest 3
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 16, 16, 16, 17});
                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 20, 24, 29, 30, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 2, 21, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 9, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 26, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 13, 13, 24, 24, 24, 21, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 11, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 30, 30, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 7, 9, 9, 9, 23, 26, 26, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 21, 21 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 27, 27, 31 });
                    woodlandHillsTrees = new List<int>(new int[] { 13, 14, 14, 14, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 11 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 13, 13, 15, 15, 15, 21, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 12, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 26, 26, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 7, 7, 7, 9, 23, 23, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 21, 21 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 27, 27, 31 });
                    woodlandHillsTrees = new List<int>(new int[] { 13, 14, 14, 15, 15, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 11 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7 });
                }
            }
            else if (elevation <= elevationLevels[13])
            {
                float rnd = mapStyle + Random.Range(-15f,15f);
                if (rnd <= 30) // Laubwald
                    temperateWoodlandTrees = new List<int>(new int[] { 16, 17, 18});
                if (rnd > 30) // Beach forest 3
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 12, 16, 17});
                if (rnd > 42) // Beach forest 1
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 16, 17, 17});
                if (rnd > 55) // Beach forest 2
                    temperateWoodlandTrees = new List<int>(new int[] { 12, 16, 16, 17});

                temperateWoodlandDeadTrees = new List<int>(new int[] { 19, 19, 20, 20, 24, 24, 29, 29, 30, 31, 31 });
                temperateWoodlandFlowers = new List<int>(new int[] { 2, 2, 2, 21, 22, 22 });
                temperateWoodlandMushroom = new List<int>(new int[] { 7, 7, 9, 9, 9, 23 });
                temperateWoodlandBushes = new List<int>(new int[] { 26, 26, 26, 27, 28 });
                temperateWoodlandBeach = new List<int>(new int[] { 31, 3, 3, 4, 4, 5, 5, 6, 29 });
                temperateWoodlandRocks = new List<int>(new int[] { 3, 4, 5, 6, 8, 10, 26 });

                if (season == DaggerfallDateTime.Seasons.Winter)
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 23, 23, 11, 11, 11, 13, 13, 24, 24, 24, 21, 25 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 11, 25 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 30, 30, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 7 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 9, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsBeach = new List<int>(new int[] { 8, 26, 29, 7, 7, 7, 23, 23 });
                    mountainsGrass = new List<int>(new int[] { 7, 9, 9, 9, 23, 26, 26, 26 });

                    woodlandHillsFlowers = new List<int>(new int[] { 7, 7, 9, 9, 21, 26, 26 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 27, 31 });
                    woodlandHillsTrees = new List<int>(new int[] { 13, 13, 14, 16, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 11 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 22, 29, 26, 9 });
                }
                else
                {
                    mountainsTrees = new List<int>(new int[] { 5, 5, 9, 9, 11, 11, 12, 13, 13, 15, 15, 15, 21, 30 });
                    mountainsNeedleTrees = new List<int>(new int[] { 5, 5, 11, 11, 12, 12, 30 });
                    mountainsDeadTrees = new List<int>(new int[] { 16, 19, 20, 26, 26, 29, 29 });
                    mountainsFlowers = new List<int>(new int[] { 22 });
                    mountainsRocks = new List<int>(new int[] { 1, 3, 4, 6, 7, 8, 10, 14, 17, 18, 27, 28, 31 });
                    mountainsGrass = new List<int>(new int[] { 2, 7, 7, 7, 9, 23, 23, 23 });

                    woodlandHillsFlowers = new List<int>(new int[] { 2, 2, 7, 7, 21, 23, 23 });
                    woodlandHillsBushes = new List<int>(new int[] { 27, 27, 31 });
                    woodlandHillsTrees = new List<int>(new int[] { 13, 14, 15, 16, 16 });
                    woodlandHillsNeedleTrees = new List<int>(new int[] { 5, 11, 11 });
                    woodlandHillsDirtPlants = new List<int>(new int[] { 26, 29, 23, 7 });
                }
            }
        }
    }
}
