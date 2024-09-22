using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BepInEx;
using UnboundLib.Cards;
using ZakCards.scripts;

namespace ZakCards {
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("pykess.rounds.plugins.moddingutils")]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")]
    [BepInPlugin("zakcards", "ZakCards", "1.0.0")]
    [BepInProcess("Rounds.exe")]
    public class ZakCards : BaseUnityPlugin
    {
        internal static string modInitials = "ZK";
        internal static AssetBundle assets;

        void Awake() {
            assets = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("zakcardsassets", typeof(ZakCards).Assembly);
            assets.LoadAsset<GameObject>("ModCards").GetComponent<CardHolder>().RegisterCards();
        }

        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
