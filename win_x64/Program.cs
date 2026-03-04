#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Reflection;

public enum weaponType
{
    None,
    WeaponProjectile,
    WeaponThrown,
    WeaponMelee
}

[Serializable]
public class InvItemLight
{
    public int invItemID;
    public int itemNetID;
    public string invItemName;
    public string invItemRealName;
    public string invItemDescription;
    public string spriteName;
    public int invItemCount;
    public bool equipped;
    public float hierarchy;
    public float hierarchy2;
    public int itemValue;
    public int slotNum;
    public int autoSortToolbarSlot;
    public int initCount;
    public int initCountAI;
    public int rewardCount;
    public int maxAmmo;
    public int lowCountThreshold;
    public bool stackable;
    public bool stackableContents;
    public bool canRepeatInShop;
    public bool nonStackableInShop;
    public bool specialDamage;
    public bool incendiaryDamage;
    public int throwDistance;
    public int throwDamage;
    public bool throwExtraDist;
    public int touchDamage;
    public int otherDamage;
    public int meleeDamage;
    public bool meleeNoHit;
    public bool nonLethal;
    public bool hasCharges;
    public bool startingItem;
    public bool canBeUsedOnDoor;
    public bool canBeUsedOnWindow;
    public bool canBeUsedOnSafe;
    public bool canBeUsedOnComputer;
    public bool isKey;
    public bool isSafeCombination;
    public bool notInLoadoutMachine;
    public bool noCountText;
    public bool doesNoDamage;
    public bool rapidFire;
    public bool shortRangeProjectile;
    public bool longerRapidFire;
    public bool noRefills;
    public bool cantStoreInATMMachine;
    public string itemType;
    public weaponType weaponCode;
    public int specificChunk;
    public int specificSector;
    public int healthChange;
    public string statusEffect;
    public bool goesInToolbar;
    public bool cantBeCloned;
    public bool dontAutomaticallySelect;
    public bool thiefCantSteal;
    public bool dontSelectNPC;
    public bool isWeapon;
    public bool isArmor;
    public bool isArmorHead;
    public bool questItem;
    public bool questItemCanBuy;
    public bool permanentHeadPiece;
    public bool behindHair;
    public bool cantShowHair;
    public bool cantShowHairAtAll;
    public bool destroyAtLevelEnd;
    public bool specialMeleeTexture;
    public bool doSpill;
    public bool canHaveStartingOwner;
    public bool stealable;
    public bool used;
    public bool addedToMoneyCount;
    public bool noSoundOnAgentHit;
    public bool weaponToBeLoaded;
    public bool reactOnTouch;
    public bool noShadow;
    public bool canCatchFire;
    public bool rechargingItem;
    public int rechargeAmount;
    public int rechargeAmountInverse;
    public int treasureVal;
    public bool canHaveExtraAmmo;
    public bool identifiedContents;
    public bool cantDrop;
    public bool cantDropNPC;
    public string cantDropSpecificCharacter;
    public bool characterExclusive;
    public string characterExclusiveSpecificCharacter;
    public string hitSoundType;
    public string armorDepletionType;
    public int startingChunk;
    public int ownerID;
    public bool canFix;
    public int tiedToItemCode;
    public List<string> Categories = new List<string>();
    public List<string> contents = new List<string>();
    public List<int> chunks = new List<int>();
    public List<int> sectors = new List<int>();
    public int speedMod;
    public int strengthMod;
    public int accuracyMod;
    public int enduranceMod;
    public int shadowOffset;
    public int chanceToWear;
    public int gunKnockback;
    public bool justAddedForNewCharacterEveryLevel;
    public bool dontFlash;
    public string colliderSize;
}

[Serializable]
public class SaveCharacterData
{
    public string characterName;
    public string characterDescription;
    public string bodyType;
    public string bodyColorName;
    public string hairType;
    public string hairColorName;
    public string facialHair = "None";
    public string skinColorName;
    public string legsColorName;
    public string eyesType;
    public string eyesColorName;
    public int endurance;
    public int strength;
    public int accuracy;
    public int speed;
    public string specialAbility;
    public string bigQuest;
    public List<string> traits = new List<string>();
    public List<string> items = new List<string>();
    public string startingHeadPiece;
    public bool exceededPoints;
    public ulong publishedFileID;
}

[Serializable]
public class Unlock
{
    public static int extraCount;
    public static int homeBaseCount;
    public static int agentCount;
    public static int bigQuestCount;
    public static int challengeCount;
    public static int floorCount;
    public static int traitCount;
    public static int traitCountCharacterCreation;
    public static int abilityCount;
    public static int itemCount;
    public static int itemCountCharacterCreation;
    public static int itemCountFree;
    public static int loadoutCount;
    public static int achievementCount;

    public string unlockName;
    public string unlockNameType;
    public string unlockDescriptionType;
    public string unlockType;
    public bool unlocked;
    public bool nowAvailable;
    public bool onlyInCharacterCreation;
    public bool removeInMech;
    public bool freeItem;
    public bool notActive;
    public bool unavailable;
    public bool removal;
    public string replacing;
    public bool isUpgrade;
    public bool cantSwap;
    public bool cantLose;
    public bool dcUnlock;
    public int progressCount;
    public List<string> progressList = new List<string>();
    public List<string> agents = new List<string>();
    public List<string> categories = new List<string>();
    public List<string> specialAbilities = new List<string>();
    public List<string> leadingTraits = new List<string>();
    public List<string> leadingItems = new List<string>();
    public List<string> leadingBigQuests = new List<string>();
    public List<string> prerequisites = new List<string>();
    public List<string> cancellations = new List<string>();
    public List<string> recommendations = new List<string>();
    public string upgrade;
    public int cost;
    public int cost2;
    public int cost3;
    public bool notOnClient;
}

[Serializable]
public class UnlockSaveData
{
    public List<Unlock> unlocks = new List<Unlock>();
    public List<HighScore> highScores = new List<HighScore>();
    public List<string> customCharacterSlots = new List<string>();
    public InvItemLight storedItem;
    public InvItemLight storedItem2;
    public InvItemLight storedItem3;
    public InvItemLight storedItem4;
    public InvItemLight storedItem5;
    public int totalDeaths;
    public int totalWins;
    public int totalGamesPlayed;
    public int nuggets;
    public string lastDailyRun;
    public bool finishedTutorial;
    public bool viewedReadThis;
    public string currentVersion;
    public List<Unlock>[] loadoutList;
    public List<string>[] rewardConfigConsoleList;
    public List<string>[] traitConfigConsoleList;
    public List<string>[] mutatorConfigConsoleList;
}

[Serializable]
public class HighScore
{
    public int skillPoints;
    public int skillLevel;
    public string agentName;
    public int finalFloor;
    public string finalFloorText;
    public float timeTaken;
    public string timeTakenText;
    public string deathMethod;
    public string deathKiller;
}

internal sealed class CustomBinder : SerializationBinder
{
    public override Type BindToType(string assemblyName, string typeName)
    {
        Assembly ResolveAssembly(AssemblyName name)
        {
            if (name.Name != null && name.Name.StartsWith("Assembly-CSharp"))
                return Assembly.GetExecutingAssembly();
            return Assembly.Load(name);
        }

        Type type = Type.GetType(typeName, ResolveAssembly, null, false, true);
        return type;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  UnlockToolConsole.exe <input.dat>                   -> output JSON to stdout");
            Console.WriteLine("  UnlockToolConsole.exe <input.dat> <output.dat>      -> read JSON from stdin, write binary");
            return;
        }

        string inputFile = args[0];
        if (!File.Exists(inputFile))
        {
            Console.Error.WriteLine($"Error: File '{inputFile}' not found.");
            Environment.Exit(1);
        }

        var jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true,
            ReferenceHandler = ReferenceHandler.Preserve
        };

        if (args.Length == 1)
        {
            try
            {
                var formatter = new BinaryFormatter { Binder = new CustomBinder() };
                using var fs = new FileStream(inputFile, FileMode.Open, FileAccess.Read);
                var data = (UnlockSaveData)formatter.Deserialize(fs);

                Console.Error.WriteLine($"[Diagnostic] Unlock count: {data.unlocks?.Count ?? 0}");
                if (data.unlocks != null && data.unlocks.Count > 0)
                    Console.Error.WriteLine($"[Diagnostic] First unlock name: {data.unlocks[0].unlockName}");
                Console.Error.WriteLine($"[Diagnostic] Nuggets: {data.nuggets}");
                Console.Error.WriteLine($"[Diagnostic] HighScore count: {data.highScores?.Count ?? 0}");
                Console.Error.WriteLine($"[Diagnostic] StoredItem null? {data.storedItem == null}");

                var json = JsonSerializer.Serialize(data, jsonOptions);
                Console.Out.Write(json);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Deserialization failed:");
                Console.Error.WriteLine(ex.ToString());
                Environment.Exit(1);
            }
        }
        else if (args.Length == 2)
        {
            string outputFile = args[1];
            string jsonStr = Console.In.ReadToEnd();

            Console.Error.WriteLine($"[Write] Received JSON length: {jsonStr.Length} bytes");

            try
            {
                var data = JsonSerializer.Deserialize<UnlockSaveData>(jsonStr, jsonOptions);
                if (data == null)
                {
                    Console.Error.WriteLine("[Write] Deserialized data is null.");
                    Environment.Exit(1);
                }

                Console.Error.WriteLine($"[Write] Unlock count: {data.unlocks?.Count ?? 0}");
                if (data.unlocks != null && data.unlocks.Count > 0)
                    Console.Error.WriteLine($"[Write] First unlock name: {data.unlocks[0].unlockName}");
                Console.Error.WriteLine($"[Write] Nuggets: {data.nuggets}");

                var formatter = new BinaryFormatter { Binder = new CustomBinder() };
                using var fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write);
                formatter.Serialize(fs, data);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Serialization failed:");
                Console.Error.WriteLine(ex.ToString());
                Environment.Exit(1);
            }
        }
    }
}