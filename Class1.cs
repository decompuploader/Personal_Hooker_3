using GTA;
using GTA.Math;
using GTA.Native;
using iFruitAddon2;
using Microsoft.CSharp.RuntimeBinder;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Personal_Hooker
{
  public class Class1 : Script
  {
    private Vector3 PlayerYachtPos1 = new Vector3(-3551.974f, 1477.896f, 12.77976f);
    private Vector3 PlayerYachtPos2 = new Vector3(-3148.379f, 2807.555f, 5.42997f);
    private Vector3 PlayerYachtPos3 = new Vector3(-3280.501f, 2140.507f, 5.42997f);
    private Vector3 PlayerYachtPos4 = new Vector3(-2814.49f, 4072.74f, 5.42997f);
    private Vector3 PlayerYachtPos5 = new Vector3(-3254.552f, 3685.677f, 5.42997f);
    private Vector3 PlayerYachtPos6 = new Vector3(-2368.441f, 4697.874f, 5.42997f);
    private Vector3 PlayerYachtPos7 = new Vector3(-3205.344f, -219.0104f, 5.42997f);
    private Vector3 PlayerYachtPos8 = new Vector3(-3448.254f, 311.5018f, 5.42997f);
    private Vector3 PlayerYachtPos9 = new Vector3(-2697.862f, -540.6123f, 5.42997f);
    private Vector3 PlayerYachtPos10 = new Vector3(-1995.725f, -1523.694f, 5.429955f);
    private Vector3 PlayerYachtPos11 = new Vector3(-2117.581f, -2543.346f, 5.42997f);
    private Vector3 PlayerYachtPos12 = new Vector3(-1605.074f, -1872.468f, 5.42997f);
    private Vector3 PlayerYachtPos13 = new Vector3(-753.0817f, -3919.068f, 5.42997f);
    private Vector3 PlayerYachtPos14 = new Vector3(-351.0608f, -3553.323f, 5.42997f);
    private Vector3 PlayerYachtPos15 = new Vector3(-1460.536f, -3761.467f, 5.42997f);
    private Vector3 PlayerYachtPos16 = new Vector3(1546.892f, -3045.627f, 5.42997f);
    private Vector3 PlayerYachtPos17 = new Vector3(2490.885f, -2428.848f, 5.42997f);
    private Vector3 PlayerYachtPos18 = new Vector3(2049.79f, -2821.624f, 5.42997f);
    private Vector3 PlayerYachtPos19 = new Vector3(3029.018f, -1495.702f, 5.42997f);
    private Vector3 PlayerYachtPos20 = new Vector3(3021.254f, -723.3903f, 5.42997f);
    private Vector3 PlayerYachtPos21 = new Vector3(2976.622f, -1994.76f, 5.42997f);
    private Vector3 PlayerYachtPos22 = new Vector3(3404.51f, 1977.044f, 5.42997f);
    private Vector3 PlayerYachtPos23 = new Vector3(3411.1f, 1193.445f, 5.42997f);
    private Vector3 PlayerYachtPos24 = new Vector3(3784.802f, 2548.541f, 5.42997f);
    private Vector3 PlayerYachtPos25 = new Vector3(4225.028f, 3988.002f, 5.42997f);
    private Vector3 PlayerYachtPos26 = new Vector3(4250.581f, 4576.565f, 5.42997f);
    private Vector3 PlayerYachtPos27 = new Vector3(4204.355f, 3373.7f, 5.42997f);
    private Vector3 PlayerYachtPos28 = new Vector3(3751.681f, 5753.501f, 5.42997f);
    private Vector3 PlayerYachtPos29 = new Vector3(3490.105f, 6305.785f, 5.42997f);
    private Vector3 PlayerYachtPos30 = new Vector3(3684.853f, 5212.238f, 5.42997f);
    private Vector3 PlayerYachtPos31 = new Vector3(581.5955f, 7124.558f, 5.42997f);
    private Vector3 PlayerYachtPos32 = new Vector3(2004.462f, 6907.157f, 5.429955f);
    private Vector3 PlayerYachtPos33 = new Vector3(1396.638f, 6860.203f, 5.42997f);
    private Vector3 PlayerYachtPos34 = new Vector3(-1170.69f, 5980.682f, 5.42997f);
    private Vector3 PlayerYachtPos35 = new Vector3(-777.4865f, 6566.907f, 5.42997f);
    private Vector3 PlayerYachtPos36 = new Vector3(-381.7739f, 6946.96f, 5.42997f);
    public Vector3 SeatPos;
    public Vector3 SitPos;
    public Vector3 StripperPos;
    public float StripperRot;
    public float chairRot;
    public Ped StripperPed;
    public Ped StripperPed2;
    public bool IsWatching;
    public int loc;
    public bool StripperActive;
    private CustomiFruit ifruit;
    private ScriptSettings Config;
    private ScriptSettings Config2;
    private Keys Key1;
    private MenuPool modMenuPool;
    private UIMenu mainMenu;
    public UIMenu Menu;
    private MenuPool modMenuPool2;
    private UIMenu mainMenu2;
    public UIMenu MenuM2;
    public UIMenu Add;
    public UIMenu Menu2;
    public UIMenu Menu3;
    public Blip StipperLocation;
    public int DanceT;
    public int HoldingStage;
    public int HoldingTimer;
    public bool IsHolding;
    public int YLOC;
    public int stage;
    public List<string> YachtLocSring = new List<string>();
    public char DanceChar;
    public Vector3 OldPos;
    public int Scene1;
    public int Scene2;
    public int LastLoc;
    public int LastYachtLoc;
    public List<string> AddonPedHash = new List<string>();
    public List<string> AddonPedName = new List<string>();
    public List<object> Stripper = new List<object>();
    public List<object> Stripper2 = new List<object>();
    public List<object> AddonLocations = new List<object>();
    public List<object> Location = new List<object>();
    public int AddonLocStart = 2;
    public UIMenuListItem L;
    public Prop Chair;
    public bool UsingChair;
    public MenuPool Woredrobepool;
    public UIMenu WoredrobeMainMenu;
    public UIMenu WoredrobeMenu;
    public int CompMax;
    public int DrawableMax;
    public bool InShower;
    public bool sitting;
    private ScriptSettings ConfigStripper;
    public WeaponTint Liv;
    public int ID_O;
    public string ID_C;
    public int Comp;
    public Model OldCharacter;
    public StripperOutfit Stripper1_Outfit;
    public StripperOutfit Stripper2_Outfit;
    public string NewLocation = "";
    public UIMenu submenu0RS;
    public bool GettingMenu;
    public bool LockHold = false;
    public bool StripperWaiting;
    public bool PlayerNear;
    public bool HasGottenUp;
    public bool SettingPreset1;
    public bool SettingPreset2;
    public bool hasPresetStripper1;
    public bool hasPresetStripper2;
    public Ped PresetPed;
    public bool ISinviewMode;
    public Camera Cam;
    public bool CameraOn;
    public Vector3 LastKnownPosition;
    public Vehicle LastVehicle;
    public bool Replay;
    public bool Holding;
    public bool LockHoldHolding;
    public bool LockHoldWaitOff;
    public bool LockHoldWaitOn;
    public int CurrentDance;
    public int Randomisation;
    public bool Goingtoposition;
    public bool TurningtoHeading;
    public bool StartingScene;
    public Prop Pole;
    public int DanceType;
    public int PolePositioning;
    public int StripperHappinessMeter;
    private float widths = 0.08f;
    private float xcoord = 0.94f;
    private int Scene3;
    public bool PlayedPlayerAnim;
    private float barperc = 0.5f;
    public int timer;
    public bool walkingtocar;
    public bool incar;
    public bool ReadyforAnims;
    public bool PlayedFirstAnim;
    public bool PlayedFirstAnim2;
    public bool HasExitedVehicle;
    public int timertillnextsound;
    public string DictToUse;
    public float Timer;
    public bool TimeLock;
    public bool PlayingEnterAnim;
    public bool PlayingEnterAnim2;
    public bool PlayingExitAnim;
    public bool PlayingExitAnim2;
    public bool PlayingExitAnim3;
    public bool RepeatAnim;
    public int AnimationLoopAmtSet = 3;
    public int AnimationLoopAmt = 0;
    public bool PlayingAnim;
    public int animtype;

    public Model RequestModel(string Name)
    {
      Model model = new Model(Name);
      model.Request(10000);
      if (model.IsInCdImage && model.IsValid)
      {
        while (!model.IsLoaded)
          Script.Wait(50);
        return model;
      }
      model.MarkAsNoLongerNeeded();
      return model;
    }

    public int CheckClothes(int T, int RComp, int RDraw, Ped P)
    {
      int num = 0;
      if (T == 1)
      {
        if (Function.Call<bool>(Hash._0xE825F6B6CEA7671D, (InputArgument) P, (InputArgument) RComp, (InputArgument) RDraw))
          num = Function.Call<int>(Hash._0x27561561732A7842, (InputArgument) P, (InputArgument) RComp);
      }
      if (T == 2)
      {
        if (Function.Call<bool>(Hash._0xE825F6B6CEA7671D, (InputArgument) P, (InputArgument) RComp, (InputArgument) RDraw))
          num = Function.Call<int>(Hash._0x8F7156A3142A6BAD, (InputArgument) P, (InputArgument) RComp, (InputArgument) RDraw);
      }
      return num;
    }

    public void Setoutfit(int i)
    {
      if (Game.Player.Character.Model != (Model) PedHash.FreemodeMale01)
        this.OldCharacter = Game.Player.Character.Model;
      Function.Call(Hash._0xAA74EC0CB0AAEA2C, (InputArgument) Game.Player.Character, (InputArgument) 1.0);
      Function.Call(Hash._0x20510814175EA477, (InputArgument) Game.Player.Character);
      Model model = new Model(PedHash.FreemodeMale01);
      model.Request(500);
      if (model.IsInCdImage && model.IsValid)
      {
        while (!model.IsLoaded)
          Script.Wait(100);
        Function.Call(Hash._0x00A1CADD00108836, (InputArgument) Game.Player, (InputArgument) model.Hash);
      }
      model.MarkAsNoLongerNeeded();
      Ped character = Game.Player.Character;
      Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) -1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 17);
      bool flag = false;
      string idC = this.ID_C;
      if (i == 0)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 125, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 125, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 125, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 3, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 125, (InputArgument) 7, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 125, (InputArgument) 5, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 125, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i == 1)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 89, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 55, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 54, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 89, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 55, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 54, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i == 2 && idC.Equals("Outfit Default"))
      {
        if (!flag && !idC.Equals("Outfit Default"))
          UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
        flag = true;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        int num = new System.Random().Next(1, 100);
        if (num <= 25)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 38, (InputArgument) 0, (InputArgument) 1);
        if (num > 25 && num <= 50)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 112, (InputArgument) 0, (InputArgument) 1);
        if (num > 50 && num <= 75)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
        if (num > 75)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 104, (InputArgument) 25, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 125, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 68, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (i == 3)
      {
        if (idC.Equals("Blue"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 3, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Green"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Red"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 5, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 5, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 5, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 5, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Orange"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Purple"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 3, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 3, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Pink"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("White"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Black") || idC.Equals("Outfit Default"))
        {
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 1, (InputArgument) 91, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 3, (InputArgument) 46, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 4, (InputArgument) 84, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 6, (InputArgument) 10, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 8, (InputArgument) 97, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 11, (InputArgument) 186, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) Game.Player.Character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i == 4)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 7, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 7, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 12, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 8, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 13, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 14, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 15, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 11, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 14, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 275, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i == 5)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 5, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 7, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 12, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 13, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 14, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 11, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 15, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 6, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 142, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 19, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 107, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 84, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 276, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i == 6)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 134, (InputArgument) 0, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 147, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 167, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 113, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 90, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 286, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 135, (InputArgument) 0);
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 134, (InputArgument) 0, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 147, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 167, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 113, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 90, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 286, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 135, (InputArgument) 0);
        }
      }
      if (i == 7)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 115, (InputArgument) 0, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 115, (InputArgument) 4, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 1, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 115, (InputArgument) 6, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 3, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 115, (InputArgument) 7, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 4, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 115, (InputArgument) 5, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 2, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 115, (InputArgument) 0, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 17, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 34, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 69, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i == 8)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 133, (InputArgument) 8, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 108, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 166, (InputArgument) 8, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 110, (InputArgument) 8, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 88, (InputArgument) 8, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 283, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 133, (InputArgument) 10, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 108, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 166, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 110, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 88, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 283, (InputArgument) 10, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 133, (InputArgument) 11, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 108, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 166, (InputArgument) 11, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 110, (InputArgument) 11, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 88, (InputArgument) 11, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 283, (InputArgument) 11, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 133, (InputArgument) 9, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 108, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 166, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 110, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 88, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 283, (InputArgument) 9, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (!flag)
        {
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 133, (InputArgument) 0, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 108, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 166, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 110, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 88, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 283, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 133, (InputArgument) 0, (InputArgument) 17);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 108, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 166, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 110, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 88, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 283, (InputArgument) 0, (InputArgument) 1);
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        }
      }
      if (i != 9)
        return;
      if (idC.Equals("Outfit Default"))
      {
        flag = true;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 91, (InputArgument) 0, (InputArgument) 17);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 77, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 55, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 178, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (idC.Equals("Green"))
      {
        flag = true;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 91, (InputArgument) 1, (InputArgument) 17);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 77, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 55, (InputArgument) 1, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 178, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (idC.Equals("White"))
      {
        flag = true;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 91, (InputArgument) 9, (InputArgument) 17);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 77, (InputArgument) 7, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 55, (InputArgument) 7, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 178, (InputArgument) 7, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (idC.Equals("Blue"))
      {
        flag = true;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 91, (InputArgument) 3, (InputArgument) 17);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 77, (InputArgument) 3, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 55, (InputArgument) 3, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 178, (InputArgument) 3, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (idC.Equals("Black"))
      {
        flag = true;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 91, (InputArgument) 10, (InputArgument) 17);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 77, (InputArgument) 10, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 55, (InputArgument) 10, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 178, (InputArgument) 10, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (!flag)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) character, (InputArgument) 0, (InputArgument) 91, (InputArgument) 0, (InputArgument) 17);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 3, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 4, (InputArgument) 77, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 6, (InputArgument) 55, (InputArgument) 0, (InputArgument) 0);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 8, (InputArgument) 130, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 11, (InputArgument) 178, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) character, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
    }

    public int GTexture(int i) => Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) this.PresetPed, (InputArgument) i);

    public int GPalette(int i) => Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) this.PresetPed, (InputArgument) i);

    public int GetClothesINC(int i)
    {
      if ((uint) i > 0U)
        ++i;
      return i;
    }

    public int GetClothesDEC(int i)
    {
      if ((uint) i > 0U)
        --i;
      return i;
    }

    public void WareDrobe()
    {
      List<object> items1 = new List<object>();
      items1.Add((object) "Save");
      items1.Add((object) "Load");
      List<object> Slots = new List<object>();
      Slots.Add((object) "Slot1.ini");
      Slots.Add((object) "Slot2.ini");
      Slots.Add((object) "Slot3.ini");
      Slots.Add((object) "Slot4.ini");
      Slots.Add((object) "Slot5.ini");
      Slots.Add((object) "Slot6.ini");
      Slots.Add((object) "Slot7.ini");
      Slots.Add((object) "Slot8.ini");
      Slots.Add((object) "Slot9.ini");
      Slots.Add((object) "Slot10.ini");
      Slots.Add((object) "Slot11.ini");
      Slots.Add((object) "Slot12.ini");
      Slots.Add((object) "Slot13.ini");
      Slots.Add((object) "Slot14.ini");
      Slots.Add((object) "Slot15.ini");
      Slots.Add((object) "Slot16.ini");
      Slots.Add((object) "Slot17.ini");
      Slots.Add((object) "Slot18.ini");
      Slots.Add((object) "Slot19.ini");
      Slots.Add((object) "Slot20.ini");
      Slots.Add((object) "Slot21.ini");
      Slots.Add((object) "Slot22.ini");
      Slots.Add((object) "Slot23.ini");
      Slots.Add((object) "Slot24.ini");
      Slots.Add((object) "Slot25.ini");
      List<object> objectList1 = new List<object>()
      {
        (object) WeaponHash.Unarmed,
        (object) WeaponHash.Knife,
        (object) WeaponHash.Nightstick,
        (object) WeaponHash.Hammer,
        (object) WeaponHash.Hatchet,
        (object) WeaponHash.KnuckleDuster,
        (object) WeaponHash.Machete,
        (object) WeaponHash.PoolCue,
        (object) WeaponHash.Wrench,
        (object) WeaponHash.SwitchBlade,
        (object) WeaponHash.GolfClub,
        (object) WeaponHash.Flashlight
      };
      List<object> objectList2 = new List<object>()
      {
        (object) "Outfit Default",
        (object) "Blue",
        (object) "Green",
        (object) "Red",
        (object) "Orange",
        (object) "Pink",
        (object) "Purple",
        (object) "White",
        (object) "Black"
      };
      List<object> objectList3 = new List<object>()
      {
        (object) "Soldier",
        (object) "Cloaker",
        (object) "Hacker",
        (object) "Juggernaut",
        (object) "Arena War A",
        (object) "Arena War B",
        (object) "Space Marine",
        (object) "Commando",
        (object) "Space Suit",
        (object) "Tron"
      };
      List<object> items2 = new List<object>();
      List<object> Draw = new List<object>();
      List<object> items3 = new List<object>();
      List<object> Tex = new List<object>();
      for (int index = 0; index < 999; ++index)
      {
        Tex.Add((object) index);
        Draw.Add((object) index);
        items3.Add((object) index);
        items2.Add((object) index);
      }
      List<object> objectList4 = new List<object>()
      {
        (object) "False",
        (object) "True"
      };
      List<object> objectList5 = new List<object>()
      {
        (object) PedHash.FreemodeFemale01,
        (object) PedHash.FreemodeMale01,
        (object) PedHash.Franklin,
        (object) PedHash.Trevor,
        (object) PedHash.Michael
      };
      List<object> items4 = new List<object>();
      items4.Add((object) "0 FACE");
      items4.Add((object) "1 BEARD");
      items4.Add((object) "2 HAIRCUT");
      items4.Add((object) "3 SHIRT");
      items4.Add((object) "4 PANTS");
      items4.Add((object) "5 Hands / Gloves");
      items4.Add((object) "6 SHOES");
      items4.Add((object) "7 Eyes");
      items4.Add((object) "8 Accessories");
      items4.Add((object) "9 Mission Items/ Tasks");
      items4.Add((object) "10 Decals");
      items4.Add((object) "11 Collars and Inner Shirts");
      UIMenu uiMenu = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Change Clothes");
      UIMenuListItem Comp1 = new UIMenuListItem("", items4, 0);
      uiMenu.AddItem((UIMenuItem) Comp1);
      UIMenuListItem Drawable = new UIMenuListItem("Item : ", items2, 0);
      uiMenu.AddItem((UIMenuItem) Drawable);
      UIMenuListItem Texture = new UIMenuListItem("Texture : ", items3, 0);
      uiMenu.AddItem((UIMenuItem) Texture);
      UIMenuItem Set = new UIMenuItem("~p~Set Stripper Outfit");
      uiMenu.AddItem(Set);
      UIMenuItem uiMenuItem = new UIMenuItem("============Save & Load Outfits=============");
      uiMenu.AddItem(uiMenuItem);
      UIMenuListItem SVL = new UIMenuListItem("Function ", items1, 0);
      uiMenu.AddItem((UIMenuItem) SVL);
      UIMenuListItem Sl = new UIMenuListItem("Slot ", Slots, 0);
      uiMenu.AddItem((UIMenuItem) Sl);
      UIMenuItem Get = new UIMenuItem("Save");
      uiMenu.AddItem(Get);
      uiMenu.OnListChange += (ListChangedEvent) ((sender, item, index) =>
      {
        if (SVL.Index == 0)
          Get.Text = "Save";
        if (SVL.Index != 1)
          return;
        Get.Text = "Load";
      });
      uiMenu.OnItemSelect += (ItemSelectEvent) ((sender, item, index) =>
      {
        if ((Entity) this.PresetPed != (Entity) null && item == Get)
        {
          if (SVL.Index == 0)
          {
            string str = "scripts//Personal Hooker//Preset_Outfits//";
            Ped presetPed = this.PresetPed;
            Get.Text = "Save";
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__1 = CallSite<Action<CallSite, Class1, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "LoadIniFile", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            Action<CallSite, Class1, object> target = Class1.\u003C\u003Eo__105.\u003C\u003Ep__1.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Action<CallSite, Class1, object>> p1 = Class1.\u003C\u003Eo__105.\u003C\u003Ep__1;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__0 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__0 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__105.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__0, str, Slots[Sl.Index]);
            target((CallSite) p1, this, obj);
            int num1 = Function.Call<int>(Hash._0x898CC20EA75BACD8, (InputArgument) presetPed, (InputArgument) 0);
            int num2 = Function.Call<int>(Hash._0xE131A28626F81AB2, (InputArgument) presetPed, (InputArgument) 0);
            int num3 = Function.Call<int>(Hash._0xE3DD5F2A84B42281, (InputArgument) presetPed, (InputArgument) 0);
            this.Config.SetValue<int>("-1 HAT", "Hat_Drawable", num1);
            this.Config.SetValue<int>("-1 Hat", "Hat_Tex", num2);
            this.Config.SetValue<int>("-1 Hat", "Hat_Palette", num3);
            int num4 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 0);
            int num5 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 0);
            this.Config.SetValue<int>("0 FACE", "Head_Drawable", num4);
            this.Config.SetValue<int>("0 FACE", "Head_Palette", num5);
            int num6 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 1);
            int num7 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 1);
            this.Config.SetValue<int>("1 BEARD", "BEARD_Drawable", num6);
            this.Config.SetValue<int>("1 BEARD", "BEARD_Palette", num7);
            int num8 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 2);
            int num9 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 2);
            this.Config.SetValue<int>("2 HAIRCUT", "HAIRCUT_Drawable", num8);
            this.Config.SetValue<int>("2 HAIRCUT", "HAIRCUT_Palette", num9);
            int num10 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 3);
            int num11 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 3);
            this.Config.SetValue<int>("3 SHIRT", "SHIRT_Drawable", num10);
            this.Config.SetValue<int>("3 SHIRT", "SHIRT_Palette", num11);
            int num12 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 4);
            int num13 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 4);
            this.Config.SetValue<int>("4 PANTS", "PANTS_Drawable", num12);
            this.Config.SetValue<int>("4 PANTS", "PANTS_Palette", num13);
            int num14 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 5);
            int num15 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 5);
            this.Config.SetValue<int>("5 Hands / Gloves", "Gloves_Drawable", num14);
            this.Config.SetValue<int>("5 Hands / Gloves", "Gloves_Palette", num15);
            int num16 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 6);
            int num17 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 6);
            this.Config.SetValue<int>("6 SHOES", "SHOES_Drawable", num16);
            this.Config.SetValue<int>("6 SHOES", "SHOES_Palette", num17);
            int num18 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 7);
            int num19 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 7);
            this.Config.SetValue<int>("7 Eyes", "Eyes_Drawable", num18);
            this.Config.SetValue<int>("7 Eyes", "Eyes_Palette", num19);
            int num20 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 8);
            int num21 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 8);
            this.Config.SetValue<int>("8 Accessories", "Accessories_Drawable", num20);
            this.Config.SetValue<int>("8 Accessories", "Accessories_Palette", num21);
            int num22 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 9);
            int num23 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 9);
            this.Config.SetValue<int>("9 Mission Items/ Tasks", "Mission_Drawable", num22);
            this.Config.SetValue<int>("9 Mission Items/ Tasks", "Mission_Palette", num23);
            int num24 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 10);
            int num25 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 10);
            this.Config.SetValue<int>("10 Decals", "Decals_Drawable", num24);
            this.Config.SetValue<int>("10 Decals", "Decals_Palette", num25);
            int num26 = Function.Call<int>(Hash._0x67F3780DD425D4FC, (InputArgument) presetPed, (InputArgument) 11);
            int num27 = Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) presetPed, (InputArgument) 11);
            this.Config.SetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Drawable", num26);
            this.Config.SetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Palette", num27);
            this.Config.Save();
            UI.Notify("Outfit saved!");
          }
          if (SVL.Index == 1)
          {
            string message = "scripts//Personal Hooker//Preset_Outfits//";
            Get.Text = "Load";
            Ped presetPed = this.PresetPed;
            UI.Notify(message);
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__3 = CallSite<Action<CallSite, Class1, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "LoadIniFile", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            Action<CallSite, Class1, object> target = Class1.\u003C\u003Eo__105.\u003C\u003Ep__3.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Action<CallSite, Class1, object>> p3 = Class1.\u003C\u003Eo__105.\u003C\u003Ep__3;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__2 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__105.\u003C\u003Ep__2.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__2, message, Slots[Sl.Index]);
            target((CallSite) p3, this, obj);
            int num1 = this.Config.GetValue<int>("0 FACE", "Head_Drawable", 0);
            int num2 = this.Config.GetValue<int>("0 FACE", "Head_Palette", 0);
            int num3 = this.Config.GetValue<int>("1 BEARD", "BEARD_Drawable", 0);
            int num4 = this.Config.GetValue<int>("1 BEARD", "BEARD_Palette", 0);
            int num5 = this.Config.GetValue<int>("2 HAIRCUT", "HAIRCUT_Drawable", 0);
            int num6 = this.Config.GetValue<int>("2 HAIRCUT", "HAIRCUT_Palette", 0);
            int num7 = this.Config.GetValue<int>("3 SHIRT", "SHIRT_Drawable", 0);
            int num8 = this.Config.GetValue<int>("3 SHIRT", "SHIRT_Palette", 0);
            int num9 = this.Config.GetValue<int>("4 PANTS", "PANTS_Drawable", 0);
            int num10 = this.Config.GetValue<int>("4 PANTS", "PANTS_Palette", 0);
            int num11 = this.Config.GetValue<int>("5 Hands / Gloves", "Gloves_Drawable", 0);
            int num12 = this.Config.GetValue<int>("5 Hands / Gloves", "Gloves_Palette", 0);
            int num13 = this.Config.GetValue<int>("6 SHOES", "SHOES_Drawable", 0);
            int num14 = this.Config.GetValue<int>("6 SHOES", "SHOES_Palette", 0);
            int num15 = this.Config.GetValue<int>("7 Eyes", "Eyes_Drawable", 0);
            int num16 = this.Config.GetValue<int>("7 Eyes", "Eyes_Palette", 0);
            int num17 = this.Config.GetValue<int>("8 Accessories", "Accessories_Drawable", 0);
            int num18 = this.Config.GetValue<int>("8 Accessories", "Accessories_Palette", 0);
            int num19 = this.Config.GetValue<int>("9 Mission Items/ Tasks", "Mission_Drawable", 0);
            int num20 = this.Config.GetValue<int>("9 Mission Items/ Tasks", "Mission_Palette", 0);
            int num21 = this.Config.GetValue<int>("10 Decals", "Decals_Drawable", 0);
            int num22 = this.Config.GetValue<int>("10 Decals", "Decals_Palette", 0);
            int num23 = this.Config.GetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Drawable", 0);
            int num24 = this.Config.GetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Palette", 0);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 0, (InputArgument) num1, (InputArgument) num2, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 1, (InputArgument) num3, (InputArgument) num4, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 2, (InputArgument) num5, (InputArgument) num6, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 3, (InputArgument) num7, (InputArgument) num8, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 4, (InputArgument) num9, (InputArgument) num10, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 5, (InputArgument) num11, (InputArgument) num12, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 6, (InputArgument) num13, (InputArgument) num14, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 7, (InputArgument) num15, (InputArgument) num16, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 8, (InputArgument) num17, (InputArgument) num18, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 9, (InputArgument) num19, (InputArgument) num20, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 10, (InputArgument) num21, (InputArgument) num22, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) presetPed, (InputArgument) 11, (InputArgument) num23, (InputArgument) num24, (InputArgument) 1);
            int num25 = this.Config.GetValue<int>("-1 HAT", "Hat_Drawable", 0);
            int num26 = this.Config.GetValue<int>("-1 Hat", "Hat_Tex", 0);
            int num27 = this.Config.GetValue<int>("-1 Hat", "Hat_Palette", 0);
            if (num25 >= 1)
              Function.Call(Hash._0x93376B65A266EB5F, (InputArgument) presetPed, (InputArgument) 0, (InputArgument) num25, (InputArgument) num26, (InputArgument) num27);
            else if (num25 < 1)
              Function.Call(Hash._0xCD8A7537A9B52F06, (InputArgument) Game.Player.Character);
          }
        }
        if (item != Set)
          return;
        if (this.SettingPreset1 && (Entity) this.PresetPed != (Entity) null)
        {
          this.hasPresetStripper1 = true;
          this.Stripper1_Outfit = new StripperOutfit(true, new StripperClothes(0, this.GTexture(0), this.GPalette(0)), new StripperClothes(1, this.GTexture(1), this.GPalette(1)), new StripperClothes(2, this.GTexture(2), this.GPalette(2)), new StripperClothes(3, this.GTexture(3), this.GPalette(3)), new StripperClothes(4, this.GTexture(4), this.GPalette(4)), new StripperClothes(5, this.GTexture(5), this.GPalette(5)), new StripperClothes(6, this.GTexture(6), this.GPalette(6)), new StripperClothes(7, this.GTexture(7), this.GPalette(7)), new StripperClothes(8, this.GTexture(8), this.GPalette(8)), new StripperClothes(9, this.GTexture(9), this.GPalette(9)), new StripperClothes(10, this.GTexture(10), this.GPalette(10)), new StripperClothes(11, this.GTexture(11), this.GPalette(11)));
          UI.Notify("Set Stripper 1 Outfit, Hit ESC to go back to ~o~ 'Request Menu'");
        }
        if (this.SettingPreset2 && (Entity) this.PresetPed != (Entity) null)
        {
          this.hasPresetStripper2 = true;
          this.Stripper2_Outfit = new StripperOutfit(true, new StripperClothes(0, this.GTexture(0), this.GPalette(0)), new StripperClothes(1, this.GTexture(1), this.GPalette(1)), new StripperClothes(2, this.GTexture(2), this.GPalette(2)), new StripperClothes(3, this.GTexture(3), this.GPalette(3)), new StripperClothes(4, this.GTexture(4), this.GPalette(4)), new StripperClothes(5, this.GTexture(5), this.GPalette(5)), new StripperClothes(6, this.GTexture(6), this.GPalette(6)), new StripperClothes(7, this.GTexture(7), this.GPalette(7)), new StripperClothes(8, this.GTexture(8), this.GPalette(8)), new StripperClothes(9, this.GTexture(9), this.GPalette(9)), new StripperClothes(10, this.GTexture(10), this.GPalette(10)), new StripperClothes(11, this.GTexture(11), this.GPalette(11)));
          UI.Notify("Set Stripper 2 Outfit, Hit ESC to go back to ~o~ 'Request Menu'");
        }
      });
      uiMenu.OnListChange += (ListChangedEvent) ((sender, item, index) =>
      {
        try
        {
          if (item == Comp1 && (Entity) this.PresetPed != (Entity) null)
          {
            if (Function.Call<int>(Hash._0x27561561732A7842, (InputArgument) this.PresetPed, (InputArgument) Comp1.Index) > Drawable.Index)
            {
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__105.\u003C\u003Ep__4 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__4.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__4, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
            }
            else
            {
              Drawable.Index = 0;
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__5 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__105.\u003C\u003Ep__5 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__5.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__5, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
            }
            if (Function.Call<int>(Hash._0x8F7156A3142A6BAD, (InputArgument) this.PresetPed, (InputArgument) Comp1.Index, (InputArgument) Drawable.Index) > Texture.Index)
            {
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__6 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__105.\u003C\u003Ep__6 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__6.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__6, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
            }
            else
            {
              Texture.Index = 0;
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__7 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__105.\u003C\u003Ep__7 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__7.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__7, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
            }
          }
          if (item == Drawable && (Entity) this.PresetPed != (Entity) null)
          {
            if (Function.Call<int>(Hash._0x27561561732A7842, (InputArgument) this.PresetPed, (InputArgument) Comp1.Index) > Drawable.Index)
            {
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__8 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__105.\u003C\u003Ep__8 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__8.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__8, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
            }
            else
            {
              Drawable.Index = 0;
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__9 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__105.\u003C\u003Ep__9 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
                {
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
                }));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__9.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__9, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
            }
          }
          if (item != Texture || !((Entity) this.PresetPed != (Entity) null))
            return;
          if (Function.Call<int>(Hash._0x8F7156A3142A6BAD, (InputArgument) this.PresetPed, (InputArgument) Comp1.Index, (InputArgument) Drawable.Index) > Texture.Index)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__10 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__10 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__105.\u003C\u003Ep__10.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__10, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
          }
          else
          {
            Texture.Index = 0;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__105.\u003C\u003Ep__11 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__105.\u003C\u003Ep__11 = CallSite<Action<CallSite, System.Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[7]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__105.\u003C\u003Ep__11.Target((CallSite) Class1.\u003C\u003Eo__105.\u003C\u003Ep__11, typeof (Function), Hash._0x262B14F48D29DE80, this.PresetPed, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
          }
        }
        catch
        {
        }
      });
    }

    public Class1()
    {
      this.YachtLocSring.Add("");
      this.YachtLocSring.Add(" Zancudo River 1 ");
      this.YachtLocSring.Add("Zancudo River 2 ");
      this.YachtLocSring.Add("Zancudo River 3 ");
      this.YachtLocSring.Add("Zancudo Base 1 ");
      this.YachtLocSring.Add("Zancudo Base 2 ");
      this.YachtLocSring.Add("Zancudo Base 3 ");
      this.YachtLocSring.Add("North Chumash 1 ");
      this.YachtLocSring.Add("North Chumash 2 ");
      this.YachtLocSring.Add("North Chumash 3 ");
      this.YachtLocSring.Add("Vespucci Beach 1 ");
      this.YachtLocSring.Add("Vespucci Beach 2 ");
      this.YachtLocSring.Add("Vespucci Beach 3 ");
      this.YachtLocSring.Add("LSIA 1 ");
      this.YachtLocSring.Add("LSIA 2 ");
      this.YachtLocSring.Add("LSIA 3 ");
      this.YachtLocSring.Add("Docks 1 ");
      this.YachtLocSring.Add("Docks 2 ");
      this.YachtLocSring.Add("Docks 3 ");
      this.YachtLocSring.Add("Palomino Highlands 1 ");
      this.YachtLocSring.Add("Palomino Highlands 2 ");
      this.YachtLocSring.Add("Palomino Highlands 3 ");
      this.YachtLocSring.Add("Tavarium Mountains 1 ");
      this.YachtLocSring.Add("Tavarium Mountains 2 ");
      this.YachtLocSring.Add("Tavarium Mountains 3 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 1 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 2 ");
      this.YachtLocSring.Add("San Chianski Mountain Range 3 ");
      this.YachtLocSring.Add("Mount Gordo 1 ");
      this.YachtLocSring.Add("Mount Gordo 2 ");
      this.YachtLocSring.Add("Mount Gordo 3 ");
      this.YachtLocSring.Add("Propocio Beach 1 ");
      this.YachtLocSring.Add("Propocio Beach 2 ");
      this.YachtLocSring.Add("Propocio Beach 3 ");
      this.YachtLocSring.Add("Paleto Bay 1 ");
      this.YachtLocSring.Add("Paleto Bay 2 ");
      this.YachtLocSring.Add("Paleto Bay 3 ");
      this.ifruit = new CustomiFruit()
      {
        CenterButtonColor = Color.Orange,
        LeftButtonColor = Color.LimeGreen,
        RightButtonColor = Color.Purple,
        CenterButtonIcon = SoftKeyIcon.Fire,
        LeftButtonIcon = SoftKeyIcon.Police,
        RightButtonIcon = SoftKeyIcon.Website
      };
      this.ifruit.SetWallpaper(new Wallpaper("char_facebook"));
      this.ifruit.SetWallpaper(Wallpaper.BadgerDefault);
      iFruitContact iFruitContact = new iFruitContact("Personal Hooker");
      iFruitContact.Answered += new ContactAnsweredEvent(this.loadMenu);
      iFruitContact.DialTimeout = 3000;
      iFruitContact.Active = true;
      iFruitContact.Icon = ContactIcon.MP_StripclubPr;
      iFruitContact.Name = "Personal Hooker";
      this.ifruit.Contacts.Add(iFruitContact);
      this.Interval = 1;
      this.Aborted += new EventHandler(this.OnShutdown);
      this.Tick += new EventHandler(this.OnTick);
      this.Setup();
    }

    public void Setup()
    {
      this.Woredrobepool = new MenuPool();
      this.WoredrobeMainMenu = new UIMenu("Clothes", "Select an Option");
      this.Woredrobepool.Add(this.WoredrobeMainMenu);
      this.WoredrobeMenu = this.Woredrobepool.AddSubMenu(this.WoredrobeMainMenu, "Change Clothes");
      this.WareDrobe();
      this.modMenuPool = new MenuPool();
      this.mainMenu = new UIMenu("Personal Hooker", "Select an Option");
      this.modMenuPool.Add(this.mainMenu);
      this.Menu = this.modMenuPool.AddSubMenu(this.mainMenu, "Request Hooker");
      this.Add = this.modMenuPool.AddSubMenu(this.mainMenu, "Add Location");
      this.modMenuPool2 = new MenuPool();
      this.mainMenu2 = new UIMenu("Personal Hooker", "Select an Option");
      this.modMenuPool2.Add(this.mainMenu2);
      this.MenuM2 = this.modMenuPool.AddSubMenu(this.mainMenu2, "Request Service");
      this.AddonPedHash.Clear();
      this.AddonPedName.Clear();
      this.Stripper.Clear();
      this.Stripper2.Clear();
      this.Stripper.Add((object) "Nikki");
      this.Stripper.Add((object) "Infernus");
      this.Stripper.Add((object) "Casisty");
      this.Stripper.Add((object) "Random");
      this.Stripper.Add((object) "Peach");
      this.Stripper.Add((object) "Cheetah");
      this.Stripper.Add((object) "Fufu");
      this.Stripper.Add((object) "Juliet");
      this.Stripper.Add((object) "Sapphire");
      this.Stripper.Add((object) "Sapphire (2)");
      this.Stripper.Add((object) "Casisty (2)");
      this.Stripper2.Add((object) "None");
      this.Stripper2.Add((object) "Nikki");
      this.Stripper2.Add((object) "Infernus");
      this.Stripper2.Add((object) "Casisty");
      this.Stripper2.Add((object) "Random");
      this.Stripper2.Add((object) "Peach");
      this.Stripper2.Add((object) "Cheetah");
      this.Stripper2.Add((object) "Fufu");
      this.Stripper2.Add((object) "Juliet");
      this.Stripper2.Add((object) "Sapphire");
      this.Stripper2.Add((object) "Sapphire (2)");
      this.Stripper2.Add((object) "Casisty (2)");
      this.Location.Add((object) "Around Player");
      foreach (string readAllLine in File.ReadAllLines("scripts\\Personal Hooker\\Personal Hooker.ini"))
      {
        if (readAllLine.Contains(","))
        {
          string[] strArray = readAllLine.Split(',');
          this.AddonPedHash.Add(strArray[0]);
          this.AddonPedName.Add(strArray[1]);
          this.Stripper.Add((object) strArray[1]);
          this.Stripper2.Add((object) strArray[1]);
        }
      }
      string[] strArray1 = File.ReadAllLines("scripts\\Personal Hooker\\AddonLocations.ini");
      if ((uint) strArray1.Length > 0U)
      {
        for (int index = 0; index < this.AddonLocStart; ++index)
          this.AddonLocations.Add((object) "null");
        foreach (string str in strArray1)
        {
          if (str.Contains("="))
          {
            this.AddonLocations.Add((object) str);
            string[] strArray2 = str.Split('=');
            this.Location.Add((object) strArray2[1]);
            int num = 0;
            while (num < strArray2.Length)
              ++num;
          }
        }
      }
      this.RequestStripper();
      this.Addlocation();
      this.RequestService();
    }

    public void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: AddonLocations.ini Failed To Load.");
      }
    }

    public void Addlocation()
    {
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.Add, "Add Location");
      UIMenuItem GET = new UIMenuItem("Create New Location (Without Chair)");
      uiMenu.AddItem(GET);
      UIMenuItem GET2 = new UIMenuItem("Create New Location (With Chair)");
      uiMenu.AddItem(GET2);
      UIMenuItem ShowROTPOS = new UIMenuItem("Get/Show Rotation & Position of Player");
      uiMenu.AddItem(ShowROTPOS);
      uiMenu.OnItemSelect += (ItemSelectEvent) ((sender, item, index) =>
      {
        if (item == GET)
        {
          string userInput = Game.GetUserInput("Enter Location Name", 25);
          if (!userInput.Equals(""))
          {
            Game.FadeScreenOut(500);
            Script.Wait(500);
            Game.Player.Character.FreezePosition = true;
            Vector3 vector3 = Game.Player.Character.Position;
            vector3 = new Vector3(vector3.X, vector3.Y, vector3.Z - 1.9f);
            Game.Player.Character.Position = vector3;
            Vector3 offsetInWorldCoords = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 1f, -0.45f));
            float heading = Game.Player.Character.Heading;
            float num = Game.Player.Character.Heading - 180f;
            this.LoadIniFile("scripts\\Personal Hooker\\AddonLocations.ini");
            string str1 = "LocationID = " + userInput + " = Stripper = " + offsetInWorldCoords.X.ToString() + "/" + offsetInWorldCoords.Y.ToString() + "/" + offsetInWorldCoords.Z.ToString() + "/" + num.ToString() + " = Player = " + vector3.X.ToString() + "/" + vector3.Y.ToString() + "/" + vector3.Z.ToString() + "/" + heading.ToString() + " = false";
            this.NewLocation = str1;
            List<object> objectList = new List<object>();
            foreach (string readAllLine in File.ReadAllLines("scripts\\Personal Hooker\\AddonLocations.ini"))
              objectList.Add((object) readAllLine);
            TextWriter textWriter = (TextWriter) new StreamWriter("scripts\\Personal Hooker\\AddonLocations.ini");
            foreach (object obj in objectList)
            {
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__110.\u003C\u003Ep__0 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__110.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (string), typeof (Class1)));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str2 = Class1.\u003C\u003Eo__110.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__110.\u003C\u003Ep__0, obj);
              textWriter.WriteLine(str2);
            }
            textWriter.WriteLine(str1);
            textWriter.Close();
            UI.Notify("Please Reload the Mod ~g~ OR ~w~ press 'Refresh Locations List' for the new location to be active");
            Game.Player.Character.FreezePosition = false;
            Script.Wait(500);
            Game.FadeScreenIn(500);
          }
          else
          {
            Game.Player.Character.FreezePosition = false;
            UI.Notify("~r~ Error ~w~ : Player did not enter a valid Location name!");
          }
        }
        if (item == GET2)
        {
          string userInput = Game.GetUserInput("Enter Location Name", 25);
          if (!userInput.Equals(""))
          {
            Game.FadeScreenOut(500);
            Script.Wait(500);
            Game.Player.Character.FreezePosition = true;
            Vector3 vector3 = Game.Player.Character.Position;
            vector3 = new Vector3(vector3.X, vector3.Y, vector3.Z - 1.45f);
            Game.Player.Character.Position = vector3;
            Vector3 offsetInWorldCoords = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 1f, -0.45f));
            float heading = Game.Player.Character.Heading;
            float num = Game.Player.Character.Heading - 180f;
            this.LoadIniFile("scripts\\Personal Hooker\\AddonLocations.ini");
            string str1 = "LocationID = " + userInput + " = Stripper = " + offsetInWorldCoords.X.ToString() + "/" + offsetInWorldCoords.Y.ToString() + "/" + offsetInWorldCoords.Z.ToString() + "/" + num.ToString() + " = Player = " + vector3.X.ToString() + "/" + vector3.Y.ToString() + "/" + vector3.Z.ToString() + "/" + heading.ToString() + " = true";
            this.NewLocation = str1;
            List<object> objectList = new List<object>();
            foreach (string readAllLine in File.ReadAllLines("scripts\\Personal Hooker\\AddonLocations.ini"))
              objectList.Add((object) readAllLine);
            TextWriter textWriter = (TextWriter) new StreamWriter("scripts\\Personal Hooker\\AddonLocations.ini");
            foreach (object obj in objectList)
            {
              // ISSUE: reference to a compiler-generated field
              if (Class1.\u003C\u003Eo__110.\u003C\u003Ep__1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                Class1.\u003C\u003Eo__110.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof (string), typeof (Class1)));
              }
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              string str2 = Class1.\u003C\u003Eo__110.\u003C\u003Ep__1.Target((CallSite) Class1.\u003C\u003Eo__110.\u003C\u003Ep__1, obj);
              textWriter.WriteLine(str2);
            }
            textWriter.WriteLine(str1);
            textWriter.Close();
            UI.Notify("Please Reload the Mod ~g~ OR ~w~ press 'Refresh Locations List' for the new location to be active");
            Game.Player.Character.FreezePosition = false;
            Script.Wait(500);
            Game.FadeScreenIn(500);
            this.AddonLocations.Add((object) str1);
          }
          else
          {
            Game.Player.Character.FreezePosition = false;
            UI.Notify("~r~ Error ~w~ : Player did not enter a valid Location name!");
          }
        }
        if (item != ShowROTPOS)
          return;
        if ((Entity) Game.Player.Character.CurrentVehicle != (Entity) null)
        {
          Vehicle currentVehicle = Game.Player.Character.CurrentVehicle;
          UI.Notify(" Rotation : ~o~" + (object) currentVehicle.Rotation.Z + "~w~                  Pos, X : ~o~ " + (object) currentVehicle.Position.X + ",~w~ Y : ~o~ " + (object) currentVehicle.Position.Y + ",~w~ Z : ~o~ " + (object) currentVehicle.Position.Z);
        }
        if ((Entity) Game.Player.Character.CurrentVehicle == (Entity) null)
        {
          Ped character = Game.Player.Character;
          UI.Notify(" Rotation : ~o~" + (object) character.Rotation.Z + "~w~                  Pos, X : ~o~ " + (object) character.Position.X + ",~w~ Y : ~o~ " + (object) character.Position.Y + ",~w~ Z : ~o~ " + (object) character.Position.Z);
        }
      });
    }

    public void RequestService()
    {
    }

    public void SetupStripper(PedHash S, int loc, int Str, bool Top, int RN)
    {
      this.LastYachtLoc = this.YLOC;
      this.LastLoc = loc;
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      this.GetLocations(loc);
      if (Str == 0)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 1)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 2)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 3)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
      }
      if (Str == 4)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 5)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 6)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 7)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 8)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 2, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 9)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 10)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      this.StripperPed.FreezePosition = true;
      this.StripperPed.BlockPermanentEvents = true;
      this.StripperPed.CanBeTargetted = false;
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      this.StipperLocation = World.CreateBlip(this.StripperPed.Position);
      this.StipperLocation.Sprite = BlipSprite.Friend;
      this.StipperLocation.Color = BlipColor.BlueLight;
      this.StipperLocation.Name = "Personal Hooker";
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
      if (!((Entity) this.StripperPed != (Entity) null))
        return;
      this.RandomiseAppearance(RN, this.StripperPed);
    }

    public void GetLocations(int loc)
    {
      if (loc == 1)
      {
        loc = 1;
        this.StripperPos = Game.Player.Character.Position.Around(100f);
        this.StripperPos = World.GetNextPositionOnSidewalk(this.StripperPos);
        this.SeatPos = new Vector3(-799.5166f, 171.4744f, 71.3f);
        this.chairRot = 74f;
        this.StripperRot = -96f;
      }
      if (loc < this.AddonLocStart)
        return;
      --loc;
      try
      {
        // ISSUE: reference to a compiler-generated field
        if (Class1.\u003C\u003Eo__114.\u003C\u003Ep__1 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Class1.\u003C\u003Eo__114.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        Func<CallSite, object, bool> target1 = Class1.\u003C\u003Eo__114.\u003C\u003Ep__1.Target;
        // ISSUE: reference to a compiler-generated field
        CallSite<Func<CallSite, object, bool>> p1 = Class1.\u003C\u003Eo__114.\u003C\u003Ep__1;
        // ISSUE: reference to a compiler-generated field
        if (Class1.\u003C\u003Eo__114.\u003C\u003Ep__0 == null)
        {
          // ISSUE: reference to a compiler-generated field
          Class1.\u003C\u003Eo__114.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Contains", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          {
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
          }));
        }
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        object obj1 = Class1.\u003C\u003Eo__114.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__114.\u003C\u003Ep__0, this.AddonLocations[loc], "=");
        if (target1((CallSite) p1, obj1))
        {
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__114.\u003C\u003Ep__3 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__114.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, string[]>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string[]), typeof (Class1)));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string[]> target2 = Class1.\u003C\u003Eo__114.\u003C\u003Ep__3.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string[]>> p3 = Class1.\u003C\u003Eo__114.\u003C\u003Ep__3;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__114.\u003C\u003Ep__2 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__114.\u003C\u003Ep__2 = CallSite<Func<CallSite, object, char, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "Split", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj2 = Class1.\u003C\u003Eo__114.\u003C\u003Ep__2.Target((CallSite) Class1.\u003C\u003Eo__114.\u003C\u003Ep__2, this.AddonLocations[loc], '=');
          string[] strArray1 = target2((CallSite) p3, obj2);
          string[] strArray2 = strArray1[3].Split('/');
          string[] strArray3 = strArray1[5].Split('/');
          this.StripperPos = new Vector3(float.Parse(strArray2[0]), float.Parse(strArray2[1]), float.Parse(strArray2[2]));
          this.SeatPos = new Vector3(float.Parse(strArray3[0]), float.Parse(strArray3[1]), float.Parse(strArray3[2]));
          this.chairRot = float.Parse(strArray3[3]);
          this.StripperRot = float.Parse(strArray2[3]);
          if (strArray1[6].Contains("false"))
            this.UsingChair = false;
          if (strArray1[6].Contains("true"))
            this.UsingChair = true;
        }
      }
      catch
      {
        UI.Notify("Could Not Create Location!");
      }
    }

    public void SetupStripper(string S, int loc, int Str, bool Top, int RN)
    {
      this.LastYachtLoc = this.YLOC;
      this.LastLoc = loc;
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      this.GetLocations(loc);
      this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
      Ped stripperPed = this.StripperPed;
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (!Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (!Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      System.Random random = new System.Random();
      int num1 = random.Next(0, 100);
      int num2 = random.Next(0, 100);
      int num3 = random.Next(0, 100);
      if (num1 < 50)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
      }
      if (num1 > 50)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (num2 < 33)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) random.Next(0, 1), (InputArgument) 1);
      if (num2 > 33 && num2 <= 66)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) random.Next(0, 2), (InputArgument) 1);
      if (num2 > 66 && num2 <= 100)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) random.Next(0, 2), (InputArgument) 1);
      if (!Top)
      {
        int num4 = 0;
        if (num3 < 50)
          num4 = 0;
        if (num3 > 50)
          num4 = 1;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) num4, (InputArgument) 1);
      }
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      this.StripperPed.FreezePosition = true;
      this.StripperPed.BlockPermanentEvents = true;
      this.StripperPed.CanBeTargetted = false;
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      this.StipperLocation = World.CreateBlip(this.StripperPed.Position);
      this.StipperLocation.Sprite = BlipSprite.Friend;
      this.StipperLocation.Color = BlipColor.BlueLight;
      this.StipperLocation.Name = "Personal Hooker";
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
      if (!((Entity) this.StripperPed != (Entity) null))
        return;
      this.RandomiseAppearance(RN, this.StripperPed);
    }

    public Ped ReturnPresetPed(PedHash S, int loc, int Str, bool Top, int RN)
    {
      this.LastYachtLoc = this.YLOC;
      this.LastLoc = loc;
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      this.GetLocations(loc);
      if (Str == 0)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 1)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 2)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 3)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
      }
      if (Str == 4)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 5)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 6)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 7)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 8)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 2, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 9)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 10)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      this.StripperPed.FreezePosition = true;
      this.StripperPed.BlockPermanentEvents = true;
      this.StripperPed.CanBeTargetted = false;
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      this.StipperLocation = World.CreateBlip(this.StripperPed.Position);
      this.StipperLocation.Sprite = BlipSprite.Friend;
      this.StipperLocation.Color = BlipColor.BlueLight;
      this.StipperLocation.Name = "Personal Hooker";
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
      if ((Entity) this.StripperPed != (Entity) null)
        this.RandomiseAppearance(RN, this.StripperPed);
      return this.StripperPed;
    }

    public Ped ReturnPresetPed(string S, int loc, int Str, bool Top, int RN)
    {
      this.LastYachtLoc = this.YLOC;
      this.LastLoc = loc;
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      this.GetLocations(loc);
      this.StripperPed = World.CreatePed(this.RequestModel(S), this.StripperPos, this.StripperRot);
      Ped stripperPed = this.StripperPed;
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (!Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (!Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      System.Random random = new System.Random();
      int num1 = random.Next(0, 100);
      int num2 = random.Next(0, 100);
      int num3 = random.Next(0, 100);
      if (num1 < 50)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
      }
      if (num1 > 50)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (num2 < 33)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) random.Next(0, 1), (InputArgument) 1);
      if (num2 > 33 && num2 <= 66)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) random.Next(0, 2), (InputArgument) 1);
      if (num2 > 66 && num2 <= 100)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) random.Next(0, 2), (InputArgument) 1);
      if (!Top)
      {
        int num4 = 0;
        if (num3 < 50)
          num4 = 0;
        if (num3 > 50)
          num4 = 1;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) num4, (InputArgument) 1);
      }
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      this.StripperPed.FreezePosition = true;
      this.StripperPed.BlockPermanentEvents = true;
      this.StripperPed.CanBeTargetted = false;
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      this.StipperLocation = World.CreateBlip(this.StripperPed.Position);
      this.StipperLocation.Sprite = BlipSprite.Friend;
      this.StipperLocation.Color = BlipColor.BlueLight;
      this.StipperLocation.Name = "Personal Hooker";
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
      if ((Entity) this.StripperPed != (Entity) null)
        this.RandomiseAppearance(RN, this.StripperPed);
      return this.StripperPed;
    }

    public Ped ReturnPresetPed_2(PedHash S, int loc, int Str, bool Top, int RN)
    {
      this.LastYachtLoc = this.YLOC;
      this.LastLoc = loc;
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      this.GetLocations(loc);
      if (Str == 0)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 1)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 2)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 3)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
      }
      if (Str == 4)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 5)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 6)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 7)
      {
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      }
      if (Str == 8)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 1, (InputArgument) 2, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 9)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 2, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (Str == 10)
      {
        S = PedHash.Stripper01SFY;
        this.StripperPed = World.CreatePed((Model) S, this.StripperPos, this.StripperRot);
        Ped stripperPed = this.StripperPed;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        if (!Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        if (Top)
          Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 2, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      this.StripperPed.FreezePosition = true;
      this.StripperPed.BlockPermanentEvents = true;
      this.StripperPed.CanBeTargetted = false;
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      this.StipperLocation = World.CreateBlip(this.StripperPed.Position);
      this.StipperLocation.Sprite = BlipSprite.Friend;
      this.StipperLocation.Color = BlipColor.BlueLight;
      this.StipperLocation.Name = "Personal Hooker";
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
      if ((Entity) this.StripperPed != (Entity) null)
        this.RandomiseAppearance(RN, this.StripperPed);
      return this.StripperPed;
    }

    public Ped ReturnPresetPed_2(string S, int loc, int Str, bool Top, int RN)
    {
      this.LastYachtLoc = this.YLOC;
      this.LastLoc = loc;
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      this.GetLocations(loc);
      this.StripperPed = World.CreatePed(this.RequestModel(S), this.StripperPos, this.StripperRot);
      Ped stripperPed = this.StripperPed;
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 1, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 5, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 7, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (!Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 9, (InputArgument) 1, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 10, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 11, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 12, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (!Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      System.Random random = new System.Random();
      int num1 = random.Next(0, 100);
      int num2 = random.Next(0, 100);
      int num3 = random.Next(0, 100);
      if (num1 < 50)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 1, (InputArgument) 1);
      }
      if (num1 > 50)
      {
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 3, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 4, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1);
      }
      if (num2 < 33)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 0, (InputArgument) random.Next(0, 1), (InputArgument) 1);
      if (num2 > 33 && num2 <= 66)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) random.Next(0, 2), (InputArgument) 1);
      if (num2 > 66 && num2 <= 100)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 2, (InputArgument) 1, (InputArgument) random.Next(0, 2), (InputArgument) 1);
      if (!Top)
      {
        int num4 = 0;
        if (num3 < 50)
          num4 = 0;
        if (num3 > 50)
          num4 = 1;
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 0, (InputArgument) num4, (InputArgument) 1);
      }
      if (Top)
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) stripperPed, (InputArgument) 8, (InputArgument) 1, (InputArgument) 1, (InputArgument) 1);
      this.StripperPed.FreezePosition = true;
      this.StripperPed.BlockPermanentEvents = true;
      this.StripperPed.CanBeTargetted = false;
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      this.StipperLocation = World.CreateBlip(this.StripperPed.Position);
      this.StipperLocation.Sprite = BlipSprite.Friend;
      this.StipperLocation.Color = BlipColor.BlueLight;
      this.StipperLocation.Name = "Personal Hooker";
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
      if ((Entity) this.StripperPed != (Entity) null)
        this.RandomiseAppearance(RN, this.StripperPed);
      return this.StripperPed;
    }

    public void RequestStripper()
    {
      List<object> objectList1 = new List<object>();
      foreach (string str in this.YachtLocSring)
        objectList1.Add((object) str);
      List<object> objectList2 = new List<object>()
      {
        (object) "Dance A",
        (object) "Dance B",
        (object) "Dance C"
      };
      List<object> items = new List<object>();
      items.Add((object) "No Randomisation");
      items.Add((object) "Randomisation 1");
      items.Add((object) "Randomisation 2");
      items.Add((object) "Randomisation 3");
      items.Add((object) "Randomisation 4");
      items.Add((object) "Randomisation 5");
      items.Add((object) "Randomisation 6");
      items.Add((object) "Randomisation 7");
      items.Add((object) "Randomisation 8");
      items.Add((object) "Randomisation 9");
      List<object> TF = new List<object>();
      TF.Add((object) false);
      TF.Add((object) true);
      List<object> objectList3 = new List<object>()
      {
        (object) "Lap Dance",
        (object) "Pole Dance"
      };
      List<object> objectList4 = new List<object>()
      {
        (object) "Non Addon Ped",
        (object) "Addon Ped",
        (object) "Slim Addon Ped"
      };
      foreach (string readAllLine in File.ReadAllLines("scripts\\Personal Hooker\\Personal Hooker.ini"))
      {
        if (!readAllLine.Contains("="))
          ;
      }
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.Menu, "Request Hooker");
      UIMenuListItem S = new UIMenuListItem("Ped : ", this.Stripper, 0);
      uiMenu.AddItem((UIMenuItem) S);
      UIMenuListItem RN = new UIMenuListItem("Randomize Outfit : ", items, 0);
      uiMenu.AddItem((UIMenuItem) RN);
      UIMenuItem PresetStripperA = new UIMenuItem("~o~ Change Ped Clothes");
      uiMenu.AddItem(PresetStripperA);
      UIMenuListItem UsePresetA = new UIMenuListItem("~o~ Use Preset ~w~ : ", TF, 0);
      uiMenu.AddItem((UIMenuItem) UsePresetA);
      UIMenuItem uiMenuItem1 = new UIMenuItem("-----------------------------------------------------------");
      this.L = new UIMenuListItem("Location : ", this.Location, 0);
      uiMenu.AddItem((UIMenuItem) this.L);
      UIMenuItem uiMenuItem2 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem2);
      UIMenuListItem T = new UIMenuListItem("Topless : ", TF, 0);
      uiMenu.AddItem((UIMenuItem) T);
      UIMenuItem uiMenuItem3 = new UIMenuItem("-----------------------------------------------------------");
      uiMenu.AddItem(uiMenuItem3);
      UIMenuItem GET = new UIMenuItem("~p~Request Ped at location");
      uiMenu.AddItem(GET);
      UIMenuItem TPP = new UIMenuItem("~p~Teleport To Ped");
      uiMenu.AddItem(TPP);
      UIMenuItem RLL = new UIMenuItem("~p~Refresh Locations List");
      uiMenu.AddItem(RLL);
      uiMenu.OnItemSelect += (ItemSelectEvent) ((sender, item, index) =>
      {
        if (item == PresetStripperA)
        {
          this.SettingPreset2 = false;
          this.SettingPreset1 = true;
          this.modMenuPool.CloseAllMenus();
          this.LastKnownPosition = Game.Player.Character.Position;
          if ((Entity) this.PresetPed != (Entity) null)
            this.PresetPed.Delete();
          if (this.Cam != (Camera) null)
          {
            World.RenderingCamera = this.Cam;
            Function.Call(Hash._0x07E5B515DB0636FC, (InputArgument) 0, (InputArgument) 0, (InputArgument) 3000, (InputArgument) 1, (InputArgument) 0);
            this.Cam.IsActive = false;
            this.Cam.Destroy();
          }
          this.Cam = World.CreateCamera(new Vector3(-1832.5f, -1260.9f, 9f), new Vector3(0.0f, 0.0f, -134f), 50f);
          Game.Player.Character.Position = this.Cam.Position;
          Game.Player.Character.Rotation = this.Cam.Rotation;
          Game.Player.Character.IsVisible = false;
          Game.Player.Character.FreezePosition = true;
          this.Cam.IsActive = true;
          this.Cam.FarClip = 2000f;
          Function.Call(Hash._0x07E5B515DB0636FC, (InputArgument) 1, (InputArgument) 0, (InputArgument) 3000, (InputArgument) 1, (InputArgument) 0);
          if (S.Index == 0)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__1.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p1 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__1;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__0 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__0 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__0.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__0, this, PedHash.StripperLite, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p1, obj);
          }
          if (S.Index == 1)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__3.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p3 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__3;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__2 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__2.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__2, this, PedHash.Stripper02SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p3, obj);
          }
          if (S.Index == 2)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__5 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__5 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__5.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p5 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__5;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__4 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__4 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__4.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__4, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p5, obj);
          }
          if (S.Index == 2)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__7 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__7 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__7.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p7 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__7;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__6 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__6 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__6.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__6, this, PedHash.StripperLite, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p7, obj);
          }
          if (S.Index == 3)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__9 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__9 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__9.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p9 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__9;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__8 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__8 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__8.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__8, this, PedHash.StripperLite, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p9, obj);
          }
          if (S.Index == 4)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__11 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__11 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__11.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p11 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__11;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__10 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__10 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__10.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__10, this, PedHash.Stripper02SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p11, obj);
          }
          if (S.Index == 5)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__13 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__13 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__13.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p13 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__13;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__12 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__12 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__12.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__12, this, PedHash.Stripper02SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p13, obj);
          }
          if (S.Index == 6)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__15 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__15 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__15.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p15 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__15;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__14 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__14 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__14.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__14, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p15, obj);
          }
          if (S.Index == 7)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__17 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__17 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__17.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p17 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__17;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__16 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__16 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__16.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__16, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p17, obj);
          }
          if (S.Index == 8)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__19 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__19 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__19.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p19 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__19;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__18 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__18 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__18.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__18, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p19, obj);
          }
          if (S.Index == 9)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__21 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__21 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__21.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p21 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__21;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__20 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__20 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__20.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__20, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p21, obj);
          }
          if (S.Index == 10)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__23 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__23 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__23.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p23 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__23;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__22 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__22 = CallSite<Func<CallSite, Class1, PedHash, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__22.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__22, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p23, obj);
          }
          if (S.Index > 10)
          {
            int index1 = S.Index - 11;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__25 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__25 = CallSite<Func<CallSite, object, Ped>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (Ped), typeof (Class1)));
            }
            // ISSUE: reference to a compiler-generated field
            Func<CallSite, object, Ped> target = Class1.\u003C\u003Eo__135.\u003C\u003Ep__25.Target;
            // ISSUE: reference to a compiler-generated field
            CallSite<Func<CallSite, object, Ped>> p25 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__25;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__24 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__24 = CallSite<Func<CallSite, Class1, string, int, int, object, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName, "ReturnPresetPed", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            object obj = Class1.\u003C\u003Eo__135.\u003C\u003Ep__24.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__24, this, this.AddonPedHash[index1], this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
            this.PresetPed = target((CallSite) p25, obj);
          }
          this.PresetPed.Position = this.Cam.GetOffsetInWorldCoords(new Vector3(0.0f, 3f, -1.25f));
          this.PresetPed.Heading = 50f;
          this.PresetPed.FreezePosition = true;
          this.ISinviewMode = true;
          this.WoredrobeMenu.Visible = true;
          if (this.StipperLocation != (Blip) null)
            this.StipperLocation.Remove();
          this.PresetPed.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + new System.Random().Next(1, 6).ToString(), 128f, -1, true, -1f);
        }
        if (item == RLL)
        {
          this.AddonLocations.Clear();
          this.Location.Clear();
          this.Location.Add((object) "Around Player");
          string[] strArray1 = File.ReadAllLines("scripts\\Personal Hooker\\AddonLocations.ini");
          if ((uint) strArray1.Length > 0U)
          {
            for (int index1 = 0; index1 < this.AddonLocStart; ++index1)
              this.AddonLocations.Add((object) "null");
            foreach (string str in strArray1)
            {
              if (str.Contains("=") && !str.Equals(this.NewLocation))
              {
                this.AddonLocations.Add((object) str);
                string[] strArray2 = str.Split('=');
                this.Location.Add((object) strArray2[1]);
                int num = 0;
                while (num < strArray2.Length)
                  ++num;
              }
            }
          }
          UI.Notify("AddonLoc " + this.AddonLocations.Count.ToString());
          if (!this.NewLocation.Equals("") && this.NewLocation.Contains("="))
          {
            this.AddonLocations.Add((object) this.NewLocation);
            string[] strArray2 = this.NewLocation.Split('=');
            this.Location.Add((object) strArray2[1]);
            int num = 0;
            while (num < strArray2.Length)
              ++num;
          }
          this.L.Index = 0;
        }
        if (item == TPP)
        {
          if ((Entity) this.StripperPed != (Entity) null)
            Game.Player.Character.Position = this.StripperPed.Position;
          else
            UI.Notify("Cannot TP to stripper!");
        }
        if (item != GET)
          return;
        try
        {
          this.PlayedFirstAnim = false;
          this.ReadyforAnims = false;
          this.incar = false;
          this.walkingtocar = false;
          this.HasGottenUp = false;
          if ((Entity) this.Pole != (Entity) null)
            this.Pole.Delete();
          this.UsingChair = false;
          if ((Entity) this.Chair != (Entity) null)
            this.Chair.Delete();
          this.DanceType = 0;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__30 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__30 = CallSite<Action<CallSite, System.Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Notify", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Action<CallSite, System.Type, object> target1 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__30.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Action<CallSite, System.Type, object>> p30 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__30;
          System.Type type = typeof (UI);
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__29 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__29 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string, object> target2 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__29.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string, object>> p29 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__29;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__28 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__28 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, object, object> target3 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__28.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, object, object>> p28 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__28;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__27 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__27 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          Func<CallSite, object, string, object> target4 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__27.Target;
          // ISSUE: reference to a compiler-generated field
          CallSite<Func<CallSite, object, string, object>> p27 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__27;
          // ISSUE: reference to a compiler-generated field
          if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__26 == null)
          {
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__26 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            {
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
              CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            }));
          }
          // ISSUE: reference to a compiler-generated field
          // ISSUE: reference to a compiler-generated field
          object obj1 = Class1.\u003C\u003Eo__135.\u003C\u003Ep__26.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__26, "Hooker : ~p~ ", this.Stripper[S.Index]);
          object obj2 = target4((CallSite) p27, obj1, "~w~, has been dropped off at ~p~");
          object obj3 = this.Location[this.L.Index];
          object obj4 = target3((CallSite) p28, obj2, obj3);
          object obj5 = target2((CallSite) p29, obj4, "~w~, she is waiting for you");
          target1((CallSite) p30, type, obj5);
          this.StripperActive = true;
          if (this.StipperLocation != (Blip) null)
            this.StipperLocation.Remove();
          if ((Entity) this.StripperPed != (Entity) null)
            this.StripperPed.Delete();
          if ((Entity) this.StripperPed2 != (Entity) null)
            this.StripperPed2.Delete();
          this.StripperPed = (Ped) null;
          this.StripperPed2 = (Ped) null;
          if (S.Index == 0)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__31 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__31 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__31.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__31, this, PedHash.StripperLite, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 1)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__32 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__32 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__32.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__32, this, PedHash.Stripper02SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 2)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__33 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__33 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__33.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__33, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 2)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__34 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__34 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__34.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__34, this, PedHash.StripperLite, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 3)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__35 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__35 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__35.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__35, this, PedHash.StripperLite, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 4)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__36 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__36 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__36.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__36, this, PedHash.Stripper02SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 5)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__37 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__37 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__37.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__37, this, PedHash.Stripper02SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 6)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__38 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__38 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__38.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__38, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 7)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__39 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__39 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__39.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__39, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 8)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__40 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__40 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__40.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__40, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 9)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__41 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__41 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__41.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__41, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index == 10)
          {
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__42 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__42 = CallSite<Action<CallSite, Class1, PedHash, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__42.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__42, this, PedHash.Stripper01SFY, this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if (S.Index > 10)
          {
            int index1 = S.Index - 11;
            // ISSUE: reference to a compiler-generated field
            if (Class1.\u003C\u003Eo__135.\u003C\u003Ep__43 == null)
            {
              // ISSUE: reference to a compiler-generated field
              Class1.\u003C\u003Eo__135.\u003C\u003Ep__43 = CallSite<Action<CallSite, Class1, string, int, int, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "SetupStripper", (IEnumerable<System.Type>) null, typeof (Class1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[6]
              {
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
                CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
              }));
            }
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            Class1.\u003C\u003Eo__135.\u003C\u003Ep__43.Target((CallSite) Class1.\u003C\u003Eo__135.\u003C\u003Ep__43, this, this.AddonPedHash[index1], this.L.Index + 1, S.Index, TF[T.Index], RN.Index);
          }
          if ((Entity) this.Chair != (Entity) null)
            this.Chair.Delete();
          if (this.DanceType == 1)
          {
            if ((Entity) this.Pole != (Entity) null)
              this.Pole.Delete();
            this.Pole = World.CreateProp(this.RequestModel("prop_strip_pole_01"), this.StripperPos, false, false);
            this.Pole.FreezePosition = true;
            this.Pole.Position = this.StripperPed.GetOffsetInWorldCoords(new Vector3(-0.05f, -0.3f, -1.2f));
          }
          if (this.UsingChair)
          {
            if ((Entity) this.Chair != (Entity) null)
              this.Chair.Delete();
            this.Chair = World.CreateProp(this.RequestModel("apa_mp_h_yacht_armchair_01"), this.StripperPed.GetOffsetInWorldCoords(new Vector3(0.0f, 1.2f, -1.1f)), new Vector3(0.0f, 0.0f, this.StripperRot), true, false);
            this.Chair.FreezePosition = true;
          }
          if ((Entity) this.Pole != (Entity) null)
          {
            this.StripperPed.Position = this.StripperPos;
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPed.Position.X, (InputArgument) this.StripperPed.Position.Y, (InputArgument) this.StripperPed.Position.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) this.StripperRot, (InputArgument) 2);
            this.StripperPed.Position = this.StripperPos;
            Class1.LoadDict("mini@strip_club@pole_dance@pole_exit");
            Class1.LoadDict("mini@strip_club@pole_dance@pole_exit");
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPed.Position.X, (InputArgument) this.StripperPed.Position.Y, (InputArgument) this.StripperPed.Position.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) this.StripperRot, (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@pole_dance@pole_exit"), (InputArgument) "pd_exit", (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "pd_exit", (InputArgument) Class1.LoadDict("mini@strip_club@pole_dance@pole_exit"), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 1063353216);
          }
          if (this.DanceType != 1)
            Script.Wait(1);
          if (this.DanceType != 1 && (Entity) this.StripperPed != (Entity) null)
          {
            this.StripperPed.Position = this.StripperPos;
            this.StripperPed.Position = this.StripperPed.GetOffsetInWorldCoords(new Vector3(-1f, 1f, -0.1f));
            this.StripperPed.Position = new Vector3(this.StripperPed.Position.X, this.StripperPed.Position.Y, World.GetGroundHeight(this.StripperPed.Position));
            Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_invite");
            this.StripperWaiting = true;
            this.PlayerNear = false;
          }
          if ((Entity) this.StripperPed != (Entity) null && this.Stripper1_Outfit != null && (this.Stripper1_Outfit.Set && UsePresetA.Index == 1))
          {
            this.PresetPed = this.StripperPed;
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 0, (InputArgument) this.Stripper1_Outfit._0.Texture, (InputArgument) this.Stripper1_Outfit._0.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 1, (InputArgument) this.Stripper1_Outfit._1.Texture, (InputArgument) this.Stripper1_Outfit._1.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 2, (InputArgument) this.Stripper1_Outfit._2.Texture, (InputArgument) this.Stripper1_Outfit._2.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 3, (InputArgument) this.Stripper1_Outfit._3.Texture, (InputArgument) this.Stripper1_Outfit._3.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 4, (InputArgument) this.Stripper1_Outfit._4.Texture, (InputArgument) this.Stripper1_Outfit._4.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 5, (InputArgument) this.Stripper1_Outfit._5.Texture, (InputArgument) this.Stripper1_Outfit._5.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 6, (InputArgument) this.Stripper1_Outfit._6.Texture, (InputArgument) this.Stripper1_Outfit._6.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 7, (InputArgument) this.Stripper1_Outfit._7.Texture, (InputArgument) this.Stripper1_Outfit._7.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 8, (InputArgument) this.Stripper1_Outfit._8.Texture, (InputArgument) this.Stripper1_Outfit._8.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 9, (InputArgument) this.Stripper1_Outfit._9.Texture, (InputArgument) this.Stripper1_Outfit._9.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 10, (InputArgument) this.Stripper1_Outfit._10.Texture, (InputArgument) this.Stripper1_Outfit._10.Palette, (InputArgument) 1);
            Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) this.PresetPed, (InputArgument) 11, (InputArgument) this.Stripper1_Outfit._11.Texture, (InputArgument) this.Stripper1_Outfit._11.Palette, (InputArgument) 1);
          }
        }
        catch
        {
          UI.Notify("~p~ Failed to spawn Hooker Model!");
        }
      });
    }

    private void DisplayHelpTextThisFrame(string text)
    {
      Function.Call(Hash._0x8509B634FBE7DA11, (InputArgument) "STRING");
      Function.Call(Hash._0x6C188BE134E074AA, (InputArgument) text);
      Function.Call(Hash._0x238FFE5C7B0498A6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 1, (InputArgument) -1);
    }

    private void OnShutdown(object sender, EventArgs e)
    {
      if (false)
        return;
      Game.Player.Character.FreezePosition = false;
      if ((Entity) this.LastVehicle != (Entity) null)
      {
        Game.Player.Character.SetIntoVehicle(this.LastVehicle, VehicleSeat.Driver);
        Game.Player.Character.CurrentVehicle.HasCollision = true;
        Game.Player.Character.CurrentVehicle.FreezePosition = false;
      }
      if (this.Cam != (Camera) null)
      {
        World.RenderingCamera = this.Cam;
        Function.Call(Hash._0x07E5B515DB0636FC, (InputArgument) 0, (InputArgument) 0, (InputArgument) 3000, (InputArgument) 1, (InputArgument) 0);
        this.Cam.IsActive = false;
        this.Cam.Destroy();
      }
      this.ISinviewMode = false;
      if ((Entity) this.PresetPed != (Entity) null)
        this.PresetPed.Delete();
      if ((Entity) this.Pole != (Entity) null)
        this.Pole.Delete();
      if (this.IsWatching)
      {
        Game.Player.Character.FreezePosition = true;
        Game.Player.Character.Position = this.StripperPos;
        Game.Player.Character.Heading = this.chairRot;
        Game.Player.Character.Task.ClearAnimation("anim@amb@office@seating@male@var_e@base@", "base");
        Game.Player.Character.FreezePosition = false;
      }
      if ((Entity) this.Chair != (Entity) null)
        this.Chair.Delete();
      if (this.StipperLocation != (Blip) null)
        this.StipperLocation.Remove();
      if ((Entity) this.StripperPed != (Entity) null)
        this.StripperPed.Delete();
      if ((Entity) this.StripperPed2 != (Entity) null)
        this.StripperPed2.Delete();
      if (!this.IsWatching)
        ;
    }

    private void DisplayHelpTextThisFrameNoSound(string text)
    {
      Function.Call(Hash._0x8509B634FBE7DA11, (InputArgument) "STRING");
      Function.Call(Hash._0x6C188BE134E074AA, (InputArgument) text);
      Function.Call(Hash._0x238FFE5C7B0498A6, (InputArgument) 0, (InputArgument) 0, (InputArgument) 0, (InputArgument) -1);
    }

    public int ReturnComponent(Ped ped, int Comp) => new System.Random().Next(0, Function.Call<int>(Hash._0x27561561732A7842, (InputArgument) ped, (InputArgument) Comp));

    public int ReturnTexture(Ped ped, int Comp, int Draw) => new System.Random().Next(0, Function.Call<int>(Hash._0x8F7156A3142A6BAD, (InputArgument) ped, (InputArgument) Comp, (InputArgument) Draw));

    public void RandomiseAppearance(int RN, Ped ped)
    {
      UI.Notify("Player Has choosen Randomisation option " + RN.ToString());
      System.Random random = new System.Random();
      if (RN == 1)
      {
        int Draw1 = this.ReturnComponent(ped, 1);
        int Draw2 = this.ReturnComponent(ped, 3);
        int Draw3 = this.ReturnComponent(ped, 4);
        int Draw4 = this.ReturnComponent(ped, 5);
        int Draw5 = this.ReturnComponent(ped, 9);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 0, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 0, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 2, Draw2), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 3, (InputArgument) Draw3, (InputArgument) this.ReturnTexture(ped, 3, Draw3), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 4, (InputArgument) Draw4, (InputArgument) this.ReturnTexture(ped, 4, Draw4), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 8, (InputArgument) Draw5, (InputArgument) this.ReturnTexture(ped, 8, Draw5), (InputArgument) 1);
      }
      if (RN == 2)
      {
        int Draw1 = this.ReturnComponent(ped, 1);
        int Draw2 = this.ReturnComponent(ped, 3);
        int Draw3 = this.ReturnComponent(ped, 4);
        int Draw4 = this.ReturnComponent(ped, 9);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 0, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 0, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 2, Draw2), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 3, (InputArgument) Draw3, (InputArgument) this.ReturnTexture(ped, 3, Draw3), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 8, (InputArgument) Draw4, (InputArgument) this.ReturnTexture(ped, 8, Draw4), (InputArgument) 1);
      }
      if (RN == 3)
      {
        int Draw1 = this.ReturnComponent(ped, 3);
        int Draw2 = this.ReturnComponent(ped, 4);
        int Draw3 = this.ReturnComponent(ped, 9);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 2, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 3, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 3, Draw2), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 8, (InputArgument) Draw3, (InputArgument) this.ReturnTexture(ped, 8, Draw3), (InputArgument) 1);
      }
      if (RN == 4)
      {
        int Draw = this.ReturnComponent(ped, 3);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw, (InputArgument) this.ReturnTexture(ped, 2, Draw), (InputArgument) 1);
      }
      if (RN == 5)
      {
        int Draw1 = this.ReturnComponent(ped, 3);
        int Draw2 = this.ReturnComponent(ped, 4);
        int Draw3 = this.ReturnComponent(ped, 5);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 2, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 3, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 3, Draw2), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 4, (InputArgument) Draw3, (InputArgument) this.ReturnTexture(ped, 4, Draw3), (InputArgument) 1);
      }
      if (RN == 6)
      {
        this.ReturnComponent(ped, 1);
        this.ReturnComponent(ped, 3);
        int Draw1 = this.ReturnComponent(ped, 4);
        int Draw2 = this.ReturnComponent(ped, 5);
        this.ReturnComponent(ped, 9);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 3, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 3, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 4, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 4, Draw2), (InputArgument) 1);
      }
      if (RN == 7)
      {
        int Draw1 = this.ReturnComponent(ped, 1);
        int Draw2 = this.ReturnComponent(ped, 3);
        this.ReturnComponent(ped, 4);
        this.ReturnComponent(ped, 5);
        this.ReturnComponent(ped, 9);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 0, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 0, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 2, Draw2), (InputArgument) 1);
      }
      if (RN == 8)
      {
        int Draw1 = this.ReturnComponent(ped, 1);
        int Draw2 = this.ReturnComponent(ped, 3);
        this.ReturnComponent(ped, 4);
        this.ReturnComponent(ped, 5);
        int Draw3 = this.ReturnComponent(ped, 9);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 0, (InputArgument) Draw1, (InputArgument) this.ReturnTexture(ped, 0, Draw1), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw2, (InputArgument) this.ReturnTexture(ped, 2, Draw2), (InputArgument) 1);
        Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 8, (InputArgument) Draw3, (InputArgument) this.ReturnTexture(ped, 8, Draw3), (InputArgument) 1);
      }
      if (RN != 9)
        return;
      int Draw6 = this.ReturnComponent(ped, 3);
      int Draw7 = this.ReturnComponent(ped, 4);
      this.ReturnComponent(ped, 5);
      this.ReturnComponent(ped, 9);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 2, (InputArgument) Draw6, (InputArgument) this.ReturnTexture(ped, 2, Draw6), (InputArgument) 1);
      Function.Call(Hash._0x262B14F48D29DE80, (InputArgument) ped, (InputArgument) 3, (InputArgument) Draw7, (InputArgument) this.ReturnTexture(ped, 3, Draw7), (InputArgument) 1);
    }

    private void drawSprite2(
      string textureDict,
      string textureName,
      float screenX,
      float screenY,
      float width,
      float height,
      int r,
      int g,
      int b,
      int alpha)
    {
      Function.Call(Hash._0xDFA2EF8E04127DD5, (InputArgument) textureDict, (InputArgument) 0);
      if (!Function.Call<bool>(Hash._0x0145F696AAAAD2E4, (InputArgument) textureDict))
        return;
      Function.Call(Hash._0xE7FFAE5EBF23D890, (InputArgument) textureDict, (InputArgument) textureName, (InputArgument) screenX, (InputArgument) screenY, (InputArgument) width, (InputArgument) height, (InputArgument) 0, (InputArgument) r, (InputArgument) g, (InputArgument) b, (InputArgument) alpha, (InputArgument) 0);
    }

    private void drawText(string text, float x, float y, float scale, int r, int g, int b)
    {
      Function.Call(Hash._0x25FBB336DF1804CB, (InputArgument) "STRING");
      Function.Call(Hash._0x6C188BE134E074AA, (InputArgument) text);
      Function.Call(Hash._0xBE6B23FFA53FB442, (InputArgument) r, (InputArgument) g, (InputArgument) b, (InputArgument) (int) byte.MaxValue);
      Function.Call(Hash._0x07C837F9A01C34C9, (InputArgument) 0.0f, (InputArgument) scale);
      Function.Call(Hash._0xCD015E5BB0D96A57, (InputArgument) x, (InputArgument) y, (InputArgument) 0.1);
    }

    private float progresswidth(float percent) => 0.08f * percent;

    private float progressxcoord(float percent) => 0.9f + 0.04f * percent;

    public static Vector3 GenerateSpawnPos(
      Vector3 desiredPos,
      Class1.Nodetype roadtype,
      bool sidewalk)
    {
      Vector3 zero = Vector3.Zero;
      bool flag = false;
      OutputArgument outputArgument = new OutputArgument();
      int num1 = 1;
      int num2 = 0;
      if (roadtype == Class1.Nodetype.AnyRoad)
        num2 = 1;
      if (roadtype == Class1.Nodetype.Road)
        num2 = 0;
      if (roadtype == Class1.Nodetype.Offroad)
      {
        num2 = 1;
        flag = true;
      }
      if (roadtype == Class1.Nodetype.Water)
        num2 = 3;
      int num3 = Function.Call<int>(Hash._0x22D7275A79FE8215, (InputArgument) desiredPos.X, (InputArgument) desiredPos.Y, (InputArgument) desiredPos.Z, (InputArgument) num1, (InputArgument) num2, (InputArgument) 300f, (InputArgument) 300f);
      if (flag)
      {
        while (true)
        {
          if (!Function.Call<bool>(Hash._0x4F5070AA58F69279, (InputArgument) num3) && num1 < 500)
          {
            ++num1;
            num3 = Function.Call<int>(Hash._0x22D7275A79FE8215, (InputArgument) desiredPos.X, (InputArgument) desiredPos.Y, (InputArgument) desiredPos.Z, (InputArgument) num1, (InputArgument) num2, (InputArgument) 300f, (InputArgument) 300f);
          }
          else
            break;
        }
      }
      Function.Call(Hash._0x703123E5E7D429C2, (InputArgument) num3, (InputArgument) outputArgument);
      Vector3 position = outputArgument.GetResult<Vector3>();
      if (sidewalk)
        position = World.GetNextPositionOnSidewalk(position);
      return position;
    }

    public string ReturnAnimtoUse(int stage, int type, string mf)
    {
      string str = "";
      if (type == 1)
      {
        if (this.DictToUse.Equals("mini@prostitutes@sexlow_veh"))
        {
          if (stage == 1)
          {
            if (mf.Equals("M"))
              return "low_car_prop_loop_player";
            if (mf.Equals("F"))
              return "low_car_prop_loop_female";
          }
          if (stage == 2)
          {
            if (mf.Equals("M"))
              return "low_car_prop_to_bj_p1_player";
            if (mf.Equals("F"))
              return "low_car_prop_to_bj_p1_female";
          }
          if (stage == 3)
          {
            if (mf.Equals("M"))
              return "low_car_prop_to_bj_p2_player";
            if (mf.Equals("F"))
              return "low_car_prop_to_bj_p2_female";
          }
          if (stage == 4)
          {
            if (mf.Equals("M"))
              return "low_car_bj_loop_player";
            if (mf.Equals("F"))
              return "low_car_bj_loop_female";
          }
          if (stage == 5)
          {
            if (mf.Equals("M"))
              return "low_car_bj_to_prop_p1_player";
            if (mf.Equals("F"))
              return "low_car_bj_to_prop_p1_female";
          }
          if (stage == 6)
          {
            if (mf.Equals("M"))
              return "low_car_bj_to_prop_p2_player";
            if (mf.Equals("F"))
              return "low_car_bj_to_prop_p2_female";
          }
        }
        if (this.DictToUse.Equals("mini@prostitutes@sexnorm_veh"))
        {
          if (stage == 1)
          {
            if (mf.Equals("M"))
              return "into_proposition_male";
            if (mf.Equals("F"))
              return "into_proposition_prostitute";
          }
          if (stage == 2)
          {
            if (mf.Equals("M"))
              return "proposition_to_bj_p1_male";
            if (mf.Equals("F"))
              return "proposition_to_bj_p1_prostitute";
          }
          if (stage == 3)
          {
            if (mf.Equals("M"))
              return "proposition_to_bj_p2_male";
            if (mf.Equals("F"))
              return "proposition_to_bj_p2_prostitute";
          }
          if (stage == 4)
          {
            if (mf.Equals("M"))
              return "bj_loop_male";
            if (mf.Equals("F"))
              return "bj_loop_prostitute";
          }
          if (stage == 5)
          {
            if (mf.Equals("M"))
              return "bj_to_proposition_p1_male";
            if (mf.Equals("F"))
              return "bj_to_proposition_p1_prostitute";
          }
          if (stage == 6)
          {
            if (mf.Equals("M"))
              return "bj_to_proposition_p2_male";
            if (mf.Equals("F"))
              return "bj_to_proposition_p2_prostitute";
          }
        }
      }
      if (type == 2 || type == 3)
      {
        if (this.DictToUse.Equals("mini@prostitutes@sexlow_veh"))
        {
          if (stage == 1)
          {
            if (mf.Equals("M"))
              return "low_car_prop_loop_player";
            if (mf.Equals("F"))
              return "low_car_prop_loop_female";
          }
          if (stage == 2)
          {
            if (mf.Equals("M"))
              return "low_car_prop_to_sex_p1_player";
            if (mf.Equals("F"))
              return "low_car_prop_to_sex_p1_female";
          }
          if (stage == 3)
          {
            if (mf.Equals("M"))
              return "low_car_prop_to_sex_p2_player";
            if (mf.Equals("F"))
              return "low_car_prop_to_sex_p2_female";
          }
          if (stage == 4)
          {
            if (mf.Equals("M"))
              return "low_car_sex_loop_player";
            if (mf.Equals("F"))
              return "low_car_sex_loop_female";
          }
          if (stage == 5)
          {
            if (mf.Equals("M"))
              return "low_car_sex_to_prop_p1_player";
            if (mf.Equals("F"))
              return "low_car_sex_to_prop_p1_female";
          }
          if (stage == 6)
          {
            if (mf.Equals("M"))
              return "low_car_sex_to_prop_p2_player";
            if (mf.Equals("F"))
              return "low_car_sex_to_prop_p2_female";
          }
        }
        if (this.DictToUse.Equals("mini@prostitutes@sexnorm_veh"))
        {
          if (stage == 1)
          {
            if (mf.Equals("M"))
              return "into_proposition_male";
            if (mf.Equals("F"))
              return "into_proposition_prostitute";
          }
          if (stage == 2)
          {
            if (mf.Equals("M"))
              return "proposition_to_sex_p1_male";
            if (mf.Equals("F"))
              return "proposition_to_sex_p1_prostitute";
          }
          if (stage == 3)
          {
            if (mf.Equals("M"))
              return "proposition_to_sex_p2_male";
            if (mf.Equals("F"))
              return "proposition_to_sex_p2_prostitute";
          }
          if (stage == 4)
          {
            if (mf.Equals("M"))
              return "sex_loop_male";
            if (mf.Equals("F"))
              return "sex_loop_prostitute";
          }
          if (stage == 5)
          {
            if (mf.Equals("M"))
              return "sex_to_proposition_p1_male";
            if (mf.Equals("F"))
              return "sex_to_proposition_p1_prostitute";
          }
          if (stage == 6)
          {
            if (mf.Equals("M"))
              return "sex_to_proposition_p2_male";
            if (mf.Equals("F"))
              return "sex_to_proposition_p2_prostitute";
          }
        }
      }
      return str;
    }

    private int GET_VEHICLE_LAYOUT_HASH(Vehicle iParam0)
    {
      if (Function.Call<bool>(Hash._0x4C241E39B23DF959, (InputArgument) iParam0, (InputArgument) 0))
      {
        switch (Function.Call<int>(Hash._0x28D37D4F71AC5C58, (InputArgument) iParam0))
        {
          case -2066252141:
          case -1887744178:
          case -1820894825:
          case -1546132012:
          case -1453479140:
          case -988377294:
          case -782720499:
          case -635697407:
          case -627376728:
          case -463340997:
          case -317944664:
          case -193022774:
          case -38413156:
          case 68566729:
          case 510359473:
          case 542797648:
          case 570040040:
          case 986556497:
          case 1192783831:
          case 1212243433:
          case 1240573865:
          case 1697345049:
          case 1837596901:
          case 2013836096:
          case 2033852426:
          case 2071837743:
          case 2130662788:
            return 1;
        }
      }
      return 0;
    }

    private void OnTick(object sender, EventArgs e)
    {
      this.ifruit.Update();
      if (this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen())
        this.modMenuPool.ProcessMenus();
      if (this.modMenuPool2 != null && this.modMenuPool2.IsAnyMenuOpen())
        this.modMenuPool2.ProcessMenus();
      this.OnKeyDown();
      if (this.Woredrobepool != null && this.Woredrobepool.IsAnyMenuOpen())
        this.Woredrobepool.ProcessMenus();
      if (this.ISinviewMode)
      {
        if (!this.Woredrobepool.IsAnyMenuOpen())
          this.WoredrobeMenu.Visible = true;
        Function.Call(Hash._0xA0EBB943C300E693, (InputArgument) false);
      }
      if (this.ISinviewMode && (Game.IsControlPressed(2, GTA.Control.FrontendPauseAlternate) || Game.IsControlPressed(2, GTA.Control.PhoneCancel)))
      {
        this.GettingMenu = false;
        this.ISinviewMode = false;
        if ((Entity) this.PresetPed != (Entity) null)
          this.PresetPed.Delete();
        if (this.Cam != (Camera) null)
        {
          World.RenderingCamera = this.Cam;
          Function.Call(Hash._0x07E5B515DB0636FC, (InputArgument) 0, (InputArgument) 0, (InputArgument) 3000, (InputArgument) 1, (InputArgument) 0);
          this.Cam.IsActive = false;
          this.Cam.Destroy();
        }
        Game.Player.Character.IsVisible = true;
        Game.Player.Character.FreezePosition = false;
        Game.Player.Character.Position = this.LastKnownPosition;
        this.Woredrobepool.CloseAllMenus();
        this.Menu.Visible = true;
        this.WoredrobeMenu.Visible = false;
        this.GettingMenu = true;
      }
      if (!this.StripperActive || !((Entity) this.StripperPed != (Entity) null))
        return;
      if ((Entity) this.StripperPed.CurrentVehicle == (Entity) null)
      {
        this.StripperPed.FreezePosition = false;
        if (!this.walkingtocar)
        {
          if (this.timer == 24)
          {
            this.timer = 0;
            this.StripperPed.Task.TurnTo((Entity) Game.Player.Character);
          }
          if (this.timer != 24)
            ++this.timer;
        }
      }
      if ((Entity) Game.Player.Character.CurrentVehicle != (Entity) null)
      {
        if ((double) World.GetDistance(Game.Player.Character.Position, this.StripperPed.Position) < 20.0 && (!this.walkingtocar && !this.incar))
          this.DisplayHelpTextThisFrame("Honk your horn to attract the Hooker");
        if (Game.IsControlJustPressed(2, GTA.Control.VehicleHorn) && (double) World.GetDistance(Game.Player.Character.Position, this.StripperPed.Position) < 20.0)
        {
          this.walkingtocar = true;
          Script.Wait(10);
          this.StripperPed.Task.EnterVehicle(Game.Player.Character.CurrentVehicle, VehicleSeat.Passenger, 22000);
        }
      }
      if (this.walkingtocar && !this.incar && (Entity) this.StripperPed.CurrentVehicle != (Entity) null)
      {
        if (this.StipperLocation != (Blip) null)
          this.StipperLocation.Remove();
        this.incar = true;
        this.DisplayHelpTextThisFrameNoSound("Take the Hooker to a sculuded area");
      }
      if (this.incar && !this.ReadyforAnims && (Entity) Game.Player.Character.CurrentVehicle != (Entity) null)
      {
        Ped[] nearbyPeds = World.GetNearbyPeds(Game.Player.Character.Position, 20f);
        if ((double) Game.Player.Character.CurrentVehicle.Speed == 0.0)
        {
          if (nearbyPeds.Length == 2)
            this.ReadyforAnims = true;
          if (nearbyPeds.Length != 2)
            this.DisplayHelpTextThisFrameNoSound("This area is not sculuded!, move to a more private spot");
        }
      }
      if (this.RepeatAnim)
      {
        if (this.animtype != 1)
        {
          if (this.timertillnextsound == 0)
          {
            this.timertillnextsound = new System.Random().Next(50, 300);
            Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) this.StripperPed, (InputArgument) "SEX_GENERIC_FEM", (InputArgument) this.getSpeechParam(6));
            Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) Game.Player.Character, (InputArgument) "SEX_GENERIC", (InputArgument) this.getSpeechParam(6));
          }
          if (this.timertillnextsound > 0)
            --this.timertillnextsound;
        }
        if (this.animtype == 1)
        {
          if (this.timertillnextsound == 0)
          {
            this.timertillnextsound = new System.Random().Next(50, 300);
            Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) this.StripperPed, (InputArgument) "SEX_ORAL_FEM", (InputArgument) this.getSpeechParam(6));
            Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) Game.Player.Character, (InputArgument) "SEX_ORAL", (InputArgument) this.getSpeechParam(6));
          }
          if (this.timertillnextsound > 0)
            --this.timertillnextsound;
        }
      }
      if (this.PlayingAnim)
      {
        if (Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1) >= 1065353216)
        {
          if (this.animtype == 1)
          {
            if (this.RepeatAnim)
              this.PlayingEnterAnim2 = true;
            if (this.PlayingEnterAnim && !this.PlayingEnterAnim2)
            {
              this.PlayingEnterAnim = false;
              this.StripperPed.Position = this.StripperPos;
              Class1.LoadDict(this.DictToUse);
              Class1.LoadDict(this.DictToUse);
              Game.Player.Character.HasCollision = false;
              Game.Player.Character.FreezePosition = true;
              Vector3 offsetInWorldCoords = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords.X, (InputArgument) offsetInWorldCoords.Y, (InputArgument) offsetInWorldCoords.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              this.PlayingEnterAnim2 = true;
            }
            else if (this.PlayingEnterAnim2)
            {
              this.PlayingEnterAnim2 = false;
              if (this.AnimationLoopAmt <= this.AnimationLoopAmtSet)
              {
                this.RepeatAnim = true;
                ++this.AnimationLoopAmt;
                this.StripperPed.Position = this.StripperPos;
                Class1.LoadDict(this.DictToUse);
                Class1.LoadDict(this.DictToUse);
                Game.Player.Character.HasCollision = false;
                Game.Player.Character.FreezePosition = true;
                Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "M"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
                Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "F"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              }
              if (this.AnimationLoopAmt > this.AnimationLoopAmtSet)
              {
                Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) Game.Player.Character, (InputArgument) "SEX_CLIMAX", (InputArgument) this.getSpeechParam(6));
                this.PlayingExitAnim = true;
                this.RepeatAnim = false;
                ++this.AnimationLoopAmt;
                this.StripperPed.Position = this.StripperPos;
                Class1.LoadDict(this.DictToUse);
                Class1.LoadDict(this.DictToUse);
                Game.Player.Character.HasCollision = false;
                Game.Player.Character.FreezePosition = true;
                Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "M"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
                Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "F"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              }
            }
            else if (this.PlayingExitAnim)
            {
              this.PlayingExitAnim = false;
              this.PlayingExitAnim2 = false;
              this.PlayingExitAnim3 = true;
              this.StripperPed.Position = this.StripperPos;
              Class1.LoadDict(this.DictToUse);
              Class1.LoadDict(this.DictToUse);
              Game.Player.Character.HasCollision = false;
              Game.Player.Character.FreezePosition = true;
              Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.8f, 0.0f, 0.0f));
              this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "F"), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            }
            else if (this.PlayingExitAnim3)
            {
              Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) this.StripperPed, (InputArgument) "HOOKER_OFFER_AGAIN", (InputArgument) this.getSpeechParam(6));
              this.PlayingExitAnim = false;
              this.PlayingExitAnim3 = false;
              this.PlayingExitAnim2 = false;
              this.PlayingAnim = false;
              this.PlayedFirstAnim2 = true;
            }
          }
          if (this.animtype == 2 || this.animtype == 3)
          {
            if (this.RepeatAnim)
              this.PlayingEnterAnim2 = true;
            if (this.PlayingEnterAnim && !this.PlayingEnterAnim2)
            {
              this.PlayingEnterAnim = false;
              this.StripperPed.Position = this.StripperPos;
              Class1.LoadDict(this.DictToUse);
              Class1.LoadDict(this.DictToUse);
              Game.Player.Character.HasCollision = false;
              Game.Player.Character.FreezePosition = true;
              Vector3 offsetInWorldCoords = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords.X, (InputArgument) offsetInWorldCoords.Y, (InputArgument) offsetInWorldCoords.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(3, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              this.PlayingEnterAnim2 = true;
            }
            else if (this.PlayingEnterAnim2)
            {
              this.PlayingEnterAnim2 = false;
              if (this.AnimationLoopAmt <= this.AnimationLoopAmtSet)
              {
                this.RepeatAnim = true;
                ++this.AnimationLoopAmt;
                this.StripperPed.Position = this.StripperPos;
                Class1.LoadDict(this.DictToUse);
                Class1.LoadDict(this.DictToUse);
                Game.Player.Character.HasCollision = false;
                Game.Player.Character.FreezePosition = true;
                Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "M"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
                Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "F"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(4, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              }
              if (this.AnimationLoopAmt > this.AnimationLoopAmtSet)
              {
                Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) Game.Player.Character, (InputArgument) "SEX_CLIMAX", (InputArgument) this.getSpeechParam(6));
                this.PlayingExitAnim = true;
                this.RepeatAnim = false;
                ++this.AnimationLoopAmt;
                this.StripperPed.Position = this.StripperPos;
                Class1.LoadDict(this.DictToUse);
                Class1.LoadDict(this.DictToUse);
                Game.Player.Character.HasCollision = false;
                Game.Player.Character.FreezePosition = true;
                Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "M"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
                Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
                this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
                Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
                Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "F"), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) 2000, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
                Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(5, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 1000.0, (InputArgument) -8.0, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              }
            }
            else if (this.PlayingExitAnim)
            {
              this.PlayingExitAnim = false;
              this.PlayingExitAnim2 = false;
              this.PlayingExitAnim3 = true;
              this.StripperPed.Position = this.StripperPos;
              Class1.LoadDict(this.DictToUse);
              Class1.LoadDict(this.DictToUse);
              Game.Player.Character.HasCollision = false;
              Game.Player.Character.FreezePosition = true;
              Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
              Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.8f, 0.0f, 0.0f));
              this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) this.ReturnAnimtoUse(6, this.animtype, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            }
            else if (this.PlayingExitAnim3)
            {
              Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) this.StripperPed, (InputArgument) "HOOKER_OFFER_AGAIN", (InputArgument) this.getSpeechParam(6));
              this.PlayingExitAnim = false;
              this.PlayingExitAnim3 = false;
              this.PlayingExitAnim2 = false;
              this.PlayingAnim = false;
              this.PlayedFirstAnim2 = true;
            }
          }
        }
      }
      if (this.HasExitedVehicle && (Entity) this.StripperPed != (Entity) null && (Entity) this.StripperPed.CurrentVehicle == (Entity) null)
      {
        this.StripperPos = Game.Player.Character.Position.Around(100f);
        this.StripperPos = Class1.GenerateSpawnPos(this.StripperPos, Class1.Nodetype.AnyRoad, true);
        this.StripperPed.Position = this.StripperPos;
        this.HasExitedVehicle = false;
      }
      if (this.PlayedFirstAnim2)
      {
        this.ShowUI();
        if (Game.IsControlJustPressed(2, GTA.Control.VehicleNextRadio) && (Entity) this.StripperPed != (Entity) null)
        {
          Game.Player.Money -= 50;
          this.PlayedFirstAnim2 = false;
          this.animtype = 1;
          this.PlayingAnim = true;
          this.PlayingExitAnim = false;
          this.AnimationLoopAmtSet = 3;
          this.AnimationLoopAmt = 0;
          this.PlayingEnterAnim = false;
          this.PlayingEnterAnim2 = false;
          this.StripperPed.Position = this.StripperPos;
          Class1.LoadDict(this.DictToUse);
          Class1.LoadDict(this.DictToUse);
          Game.Player.Character.HasCollision = false;
          Game.Player.Character.FreezePosition = true;
          Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(2, 1, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(2, 1, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.8f, 0.0f, 0.0f));
          this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(2, 1, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) this.ReturnAnimtoUse(2, 1, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          this.PlayingEnterAnim = true;
          this.modMenuPool2.CloseAllMenus();
        }
        if (Game.IsControlJustPressed(2, GTA.Control.VehiclePrevRadio) && (Entity) this.StripperPed != (Entity) null)
        {
          Game.Player.Money -= 75;
          this.PlayedFirstAnim2 = false;
          this.animtype = 2;
          this.PlayingAnim = true;
          this.PlayingExitAnim = false;
          this.AnimationLoopAmtSet = 3;
          this.AnimationLoopAmt = 0;
          this.PlayingEnterAnim = false;
          this.PlayingEnterAnim2 = false;
          this.StripperPed.Position = this.StripperPos;
          Class1.LoadDict(this.DictToUse);
          Class1.LoadDict(this.DictToUse);
          Game.Player.Character.HasCollision = false;
          Game.Player.Character.FreezePosition = true;
          Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(2, 2, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(2, 2, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.8f, 0.0f, 0.0f));
          this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(2, 2, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) this.ReturnAnimtoUse(2, 2, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          this.PlayingEnterAnim = true;
          this.modMenuPool2.CloseAllMenus();
        }
        if (Game.IsControlJustPressed(2, GTA.Control.VehicleNextRadioTrack) && (Entity) this.StripperPed != (Entity) null)
        {
          Game.Player.Money -= 100;
          this.PlayedFirstAnim2 = false;
          this.animtype = 3;
          this.PlayingAnim = true;
          this.PlayingExitAnim = false;
          this.AnimationLoopAmtSet = 6;
          this.AnimationLoopAmt = 0;
          this.PlayingEnterAnim = false;
          this.PlayingEnterAnim2 = false;
          this.StripperPed.Position = this.StripperPos;
          Class1.LoadDict(this.DictToUse);
          Class1.LoadDict(this.DictToUse);
          Game.Player.Character.HasCollision = false;
          Game.Player.Character.FreezePosition = true;
          Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.0f, 0.0f));
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(2, 2, "M"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(2, 2, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.8f, 0.0f, 0.0f));
          this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(2, 2, "F"), (InputArgument) 12000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) this.ReturnAnimtoUse(2, 2, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 12000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          this.PlayingEnterAnim = true;
          this.modMenuPool2.CloseAllMenus();
        }
        if (Game.IsControlJustPressed(2, GTA.Control.VehiclePrevRadioTrack))
        {
          this.PlayedFirstAnim2 = false;
          Game.Player.Character.SetIntoVehicle(this.LastVehicle, VehicleSeat.Driver);
          this.StripperPed.SetIntoVehicle(this.LastVehicle, VehicleSeat.Passenger);
          Game.Player.Character.CurrentVehicle.HasCollision = true;
          Game.Player.Character.CurrentVehicle.FreezePosition = false;
          this.StripperPed.Task.LeaveVehicle(LeaveVehicleFlags.None);
          this.HasExitedVehicle = true;
          Game.Player.Character.FreezePosition = false;
          this.LastVehicle = (Vehicle) null;
        }
      }
      if (this.ReadyforAnims && !this.PlayedFirstAnim && ((Entity) this.StripperPed != (Entity) null && (Entity) Game.Player.Character.CurrentVehicle != (Entity) null))
      {
        this.PlayedFirstAnim2 = true;
        this.PlayedFirstAnim = true;
        this.PlayingExitAnim = false;
        this.PlayingEnterAnim = false;
        this.PlayingEnterAnim2 = false;
        this.StripperPed.Position = this.StripperPos;
        this.StripperPed.Voice = "a_f_y_hipster_01_white_full_01";
        this.DictToUse = "mini@prostitutes@sexlow_veh";
        Class1.LoadDict(this.DictToUse);
        Class1.LoadDict(this.DictToUse);
        this.LastVehicle = Game.Player.Character.CurrentVehicle;
        Game.Player.Character.CurrentVehicle.HasCollision = false;
        Game.Player.Character.CurrentVehicle.FreezePosition = true;
        Game.Player.Character.HasCollision = false;
        Game.Player.Character.FreezePosition = true;
        Vector3 offsetInWorldCoords1 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(-0.05f, 0.0f, 0.0f));
        this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords1.X, (InputArgument) offsetInWorldCoords1.Y, (InputArgument) offsetInWorldCoords1.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
        Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
        Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(1, 1, "M"), (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
        Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(1, 1, "M"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
        Vector3 offsetInWorldCoords2 = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.8f, 0.0f, 0.0f));
        this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords2.X, (InputArgument) offsetInWorldCoords2.Y, (InputArgument) offsetInWorldCoords2.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
        Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
        Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) this.ReturnAnimtoUse(1, 1, "F"), (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
        Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) this.ReturnAnimtoUse(1, 1, "F"), (InputArgument) Class1.LoadDict(this.DictToUse), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
        Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) this.StripperPed, (InputArgument) "HOOKER_OFFER_SERVICE", (InputArgument) this.getSpeechParam(6));
      }
    }

    public void PlayScene()
    {
      Game.Player.Character.Weapons.Select(WeaponHash.Unarmed);
      this.LockHold = false;
      System.Random random = new System.Random();
      this.StripperHappinessMeter = random.Next(100, 1000);
      Game.Player.Character.FreezePosition = true;
      Game.Player.Character.Position = this.SeatPos;
      Game.Player.Character.Heading = this.chairRot;
      Function.Call(Hash._0xB4EC2312F4E5B1F1, (InputArgument) 0.0f);
      Function.Call(Hash._0x6D0858B8EDFD2B7D, (InputArgument) 0.0f);
      this.stage = 0;
      if (this.DanceType == 0)
      {
        Game.Player.Character.Task.PlayAnimation("mini@strip_club@lap_dance@ld_reach", "ld_sit_idle", 128f, -1, true, -1f);
        if ((Entity) this.StripperPed2 == (Entity) null)
        {
          Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro");
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) new Vector3(Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) "ld_girl_a_intro_f", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_girl_a_intro_f", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) "ld_girl_a_intro_m", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) "ld_girl_a_intro_m", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) (this.StripperPed.Rotation.Z - 180f), (InputArgument) 1148846080, (InputArgument) 0);
          Script.Wait(4500);
        }
        if ((Entity) this.StripperPed2 != (Entity) null)
        {
          string dict = "mini@strip_club@lap_dance_2g@ld_2g_intro";
          Class1.LoadDict(dict);
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) new Vector3(Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) "ld_2g_intro_s1", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_intro_s1", (InputArgument) Class1.LoadDict(dict), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) "ld_2g_intro_s2", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_intro_s2", (InputArgument) Class1.LoadDict(dict), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) "ld_2g_intro_m", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) "ld_2g_intro_m", (InputArgument) Class1.LoadDict(dict), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) (this.StripperPed.Rotation.Z - 180f), (InputArgument) 1148846080, (InputArgument) 0);
          Script.Wait(4000);
        }
        this.HoldingStage = 0;
        this.IsHolding = false;
        this.IsWatching = true;
        if ((Entity) this.StripperPed != (Entity) null)
        {
          this.StripperPos = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.1f, 0.05f, -0.5f));
          this.StripperActive = true;
          random.Next(1, 100);
          if ((Entity) this.StripperPed2 == (Entity) null)
          {
            if (this.DanceT == 0)
            {
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_song_a_p1"), (InputArgument) "ld_girl_a_song_a_p1_f", (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_girl_a_song_a_p1_f", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_song_a_p1"), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            }
            if (this.DanceT == 1)
            {
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_song_a_p2"), (InputArgument) "ld_girl_a_song_a_p2_f", (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_girl_a_song_a_p2_f", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_song_a_p2"), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            }
            if (this.DanceT == 2)
            {
              this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
              Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_song_a_p3"), (InputArgument) "ld_girl_a_song_a_p3_f", (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
              Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
              Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_girl_a_song_a_p3_f", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_song_a_p3"), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            }
          }
        }
        if ((Entity) this.StripperPed2 != (Entity) null)
        {
          this.StripperPos = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.0f, 0.12f, -0.5f));
          if (this.DanceT == 0)
          {
            this.DanceChar = 'A';
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) "ld_2g_p1_s1", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) "ld_2g_p1_s2", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p1_s1", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p1_s2", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed2.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          if (this.DanceT == 1)
          {
            this.DanceChar = 'B';
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p2"), (InputArgument) "ld_2g_p2_s1", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p2"), (InputArgument) "ld_2g_p2_s2", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p2_s1", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p2"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p2_s2", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p2"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed2.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          if (this.DanceT == 2)
          {
            this.DanceChar = 'C';
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p3"), (InputArgument) "ld_2g_p3_s1", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p3"), (InputArgument) "ld_2g_p3_s2", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p3_s1", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p3"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p3_s2", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p3"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed2.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          if (this.DanceT == 3)
          {
            this.DanceChar = 'D';
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPos.X, (InputArgument) this.StripperPos.Y, (InputArgument) new Vector3(this.StripperPos.X, this.StripperPos.Y, this.StripperPos.Z + 0.5f).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperPed.Rotation.Z + 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) "ld_2g_p1_s1", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) "ld_2g_p1_s2", (InputArgument) 1000.0, (InputArgument) -4.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p1_s1", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_p1_s2", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance_2g@ld_2g_p1"), (InputArgument) 1000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed2.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
        }
        if ((Entity) this.StripperPed2 == (Entity) null)
        {
          this.StripperActive = true;
          Vector3 position = this.StripperPed.Position;
          random.Next(1, 6);
          float z = this.StripperPed.Position.Z;
          this.StripperPed.Position = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.1f, 0.4f, -0.4f));
        }
        if ((Entity) this.StripperPed2 != (Entity) null)
        {
          this.StripperActive = true;
          Vector3 position = this.StripperPed2.Position;
          this.StripperPed2.Position = this.StripperPos;
          float z = this.StripperPed2.Position.Z;
          this.StripperPed2.Position = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(0.22f, -0.3f, -0.4f));
          z = this.StripperPed.Position.Z;
          position = this.StripperPed.Position;
          this.StripperPed.Position = this.StripperPos;
          this.StripperPed.Position = Game.Player.Character.GetOffsetInWorldCoords(new Vector3(-0.22f, -0.3f, -0.4f));
          this.StripperPed.Rotation = new Vector3(0.0f, 0.0f, this.StripperRot);
          this.StripperPed2.Rotation = new Vector3(0.0f, 0.0f, this.StripperRot);
        }
        Game.Player.Character.Task.PlayAnimation("mini@strip_club@lap_dance@ld_reach", "ld_sit_idle", 128f, -1, true, -1f);
      }
      if (this.DanceType == 1)
      {
        if ((Entity) this.StripperPed2 == (Entity) null)
        {
          Game.Player.Character.FreezePosition = true;
          Game.Player.Character.Position = this.SeatPos;
          Game.Player.Character.Heading = this.chairRot;
          string dict = "mini@strip_club@lap_dance@ld_girl_a_intro";
          Class1.LoadDict(dict);
          Class1.LoadDict(dict);
          this.Scene3 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) Game.Player.Character.Position.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene3, (InputArgument) 0.0);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene3, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) "ld_girl_a_intro_m", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene3, (InputArgument) "ld_girl_a_intro_m", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) (this.StripperPed.Rotation.Z - 180f), (InputArgument) 1148846080, (InputArgument) 0);
          Script.Wait(100);
          this.PlayedPlayerAnim = true;
        }
        if ((Entity) this.Pole != (Entity) null)
        {
          this.StripperPed.Position = this.StripperPos;
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPed.Position.X, (InputArgument) this.StripperPed.Position.Y, (InputArgument) this.StripperPed.Position.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) this.StripperRot, (InputArgument) 2);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@pole_dance@pole_enter"), (InputArgument) "pd_enter", (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "pd_enter", (InputArgument) Class1.LoadDict("mini@strip_club@pole_dance@pole_enter"), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
        }
        this.HoldingStage = 0;
        this.IsHolding = false;
        this.IsWatching = true;
      }
      this.HasGottenUp = false;
    }

    public void StopScene()
    {
      Game.Player.Character.Weapons.Select(WeaponHash.Unarmed);
      this.Timer = 0.0f;
      int lastLoc = this.LastLoc;
      int yloc = this.YLOC;
      this.GetLocations(lastLoc);
      Function.Call(Hash._0x8E04FEDD28D42462, (InputArgument) Game.Player.Character, (InputArgument) "STRIP_DANCE_QUIT", (InputArgument) this.getSpeechParam(6));
      if (this.DanceType == 0)
      {
        Game.Player.Character.Task.PlayAnimation("mini@strip_club@lap_dance@ld_reach", "ld_sit_idle", 128f, -1, true, -1f);
        this.HoldingStage = 0;
        this.IsHolding = false;
        if ((Entity) this.StripperPed2 == (Entity) null)
        {
          string dict1 = "mini@strip_club@lap_dance@ld_girl_a_exit";
          Class1.LoadDict(dict1);
          Class1.LoadDict(dict1);
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) new Vector3(Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          int num = new System.Random().Next(0, 100);
          if (num >= 50)
          {
            string dict2 = "mini@strip_club@lap_dance@ld_girl_a_exit";
            Class1.LoadDict(dict2);
            Class1.LoadDict(dict2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_exit"), (InputArgument) "ld_girl_a_exit_f", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_girl_    a_exit_f", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_exit"), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          if (num < 50)
          {
            string dict2 = "mini@strip_club@lap_dance@ld_girl_a_decline";
            Class1.LoadDict(dict2);
            Class1.LoadDict(dict2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_decline"), (InputArgument) "ld_girl_a_decline_f", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_girl_a_decline_f", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_decline"), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          string dict3 = "anim@amb@office@seating@male@var_a@base@";
          Class1.LoadDict(dict3);
          Class1.LoadDict(dict3);
          Script.Wait(4000);
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) (Game.Player.Character.Position.Z - 0.6f), (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (Game.Player.Character.Rotation.Z - 180f), (InputArgument) 2);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict3), (InputArgument) "exit", (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) "exit", (InputArgument) Class1.LoadDict(dict3), (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
          Script.Wait(4000);
          Game.Player.Character.Task.ClearAll();
        }
        if ((Entity) this.StripperPed2 != (Entity) null)
        {
          string dict1 = "mini@strip_club@lap_dance_2g@ld_2g_exit";
          Class1.LoadDict(dict1);
          Class1.LoadDict(dict1);
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) new Vector3(Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z).Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
          int num = new System.Random().Next(0, 100);
          if (num >= 50)
          {
            string dict2 = "mini@strip_club@lap_dance_2g@ld_2g_exit";
            Class1.LoadDict(dict2);
            Class1.LoadDict(dict2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict2), (InputArgument) "ld_2g_exit_s1", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_exit_s1", (InputArgument) Class1.LoadDict(dict2), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict2), (InputArgument) "ld_2g_exit_s2", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_exit_s2", (InputArgument) Class1.LoadDict(dict2), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          if (num < 50)
          {
            string dict2 = "mini@strip_club@lap_dance_2g@ld_2g_decline";
            Class1.LoadDict(dict2);
            Class1.LoadDict(dict2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict2), (InputArgument) "ld_2g_decline_s1", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "ld_2g_decline_s1", (InputArgument) Class1.LoadDict(dict2), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict2), (InputArgument) "ld_2g_decline_s2", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) "ld_2g_decline_s2", (InputArgument) Class1.LoadDict(dict2), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          string dict3 = "anim@amb@office@seating@male@var_a@base@";
          Class1.LoadDict(dict3);
          Class1.LoadDict(dict3);
          Script.Wait(4000);
          this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) (Game.Player.Character.Position.Z - 0.6f), (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (Game.Player.Character.Rotation.Z - 180f), (InputArgument) 2);
          Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict3), (InputArgument) "exit", (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
          Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
          Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) "exit", (InputArgument) Class1.LoadDict(dict3), (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
          Script.Wait(4000);
          Game.Player.Character.Task.ClearAll();
        }
        this.IsWatching = false;
        if ((Entity) this.StripperPed != (Entity) null)
        {
          this.StripperActive = true;
          new System.Random().Next(1, 6);
          this.StripperPed.Task.ClearAll();
          this.StripperPed.Position = this.StripperPos;
          this.StripperPed.Rotation = new Vector3(0.0f, 0.0f, this.StripperRot);
          if ((Entity) this.StripperPed != (Entity) null)
          {
            this.StripperPed.Position = this.StripperPos;
            Vector3 offsetInWorldCoords = this.StripperPed.GetOffsetInWorldCoords(new Vector3(-1f, 1f, -0.1f));
            this.StripperPed.Position = offsetInWorldCoords;
            string dict = "mini@strip_club@lap_dance@ld_girl_a_invite";
            string str = "ld_girl_a_invite";
            Class1.LoadDict(dict);
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords.X, (InputArgument) offsetInWorldCoords.Y, (InputArgument) offsetInWorldCoords.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperRot - 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) str, (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) str, (InputArgument) Class1.LoadDict(dict), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xB6C49F8A5E295A5D, (InputArgument) this.Scene1, (InputArgument) 0);
            this.StripperWaiting = true;
            this.PlayerNear = false;
          }
        }
        if ((Entity) this.StripperPed2 != (Entity) null)
        {
          this.StripperPed2.Task.ClearAll();
          this.StripperActive = true;
          int num = new System.Random().Next(1, 6);
          this.StripperPed2.Rotation = new Vector3(0.0f, 0.0f, this.StripperRot);
          this.StripperPed2.Task.PlayAnimation("mini@strip_club@idles@stripper", "stripper_idle_0" + num.ToString(), 128f, -1, true, -1f);
        }
        if ((Entity) this.StripperPed2 != (Entity) null)
        {
          this.StripperPed.Task.ClearAll();
          this.StripperPed2.Task.ClearAll();
          Vector3 position1 = this.StripperPed2.Position;
          this.StripperPed2.Position = this.StripperPos;
          this.StripperPed2.Position = this.StripperPed2.GetOffsetInWorldCoords(new Vector3(-0.21f, 0.0f, 0.0f));
          Vector3 position2 = this.StripperPed2.Position;
          this.StripperPed2.Position = new Vector3(position2.X, position2.Y, this.StripperPos.Z);
          position1 = this.StripperPed.Position;
          this.StripperPed.Position = this.StripperPos;
          this.StripperPed.Position = this.StripperPed.GetOffsetInWorldCoords(new Vector3(0.21f, 0.0f, 0.0f));
          Vector3 position3 = this.StripperPed.Position;
          this.StripperPed.Position = new Vector3(position3.X, position3.Y, this.StripperPos.Z);
          if ((Entity) this.StripperPed2 != (Entity) null)
          {
            this.StripperPed.Position = this.StripperPos;
            Vector3 offsetInWorldCoords = this.StripperPed.GetOffsetInWorldCoords(new Vector3(0.0f, 1.1f, -0.5f));
            this.StripperPed.Position = offsetInWorldCoords;
            string dict = "mini@strip_club@lap_dance_2g@ld_2g_wait";
            string str1 = "ld_2g_wait_s2";
            string str2 = "ld_2g_wait_s1";
            Class1.LoadDict(dict);
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) offsetInWorldCoords.X, (InputArgument) offsetInWorldCoords.Y, (InputArgument) offsetInWorldCoords.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (this.StripperRot - 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) str1, (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) str1, (InputArgument) Class1.LoadDict(dict), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) str2, (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed2, (InputArgument) this.Scene1, (InputArgument) str2, (InputArgument) Class1.LoadDict(dict), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
            this.StripperWaiting = true;
            this.PlayerNear = false;
          }
        }
        Game.Player.Character.FreezePosition = false;
      }
      if (this.DanceType == 1)
      {
        Game.Player.Character.Task.PlayAnimation("mini@strip_club@lap_dance@ld_reach", "ld_sit_idle", 128f, -1, true, -1f);
        this.HoldingStage = 0;
        this.IsHolding = false;
        if ((Entity) this.StripperPed2 == (Entity) null)
        {
          if ((Entity) this.Pole != (Entity) null)
          {
            Class1.LoadDict("mini@strip_club@pole_dance@pole_exit");
            this.StripperPed.Position = this.StripperPos;
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) this.StripperPed.Position.X, (InputArgument) this.StripperPed.Position.Y, (InputArgument) this.StripperPed.Position.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) this.StripperRot, (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict("mini@strip_club@pole_dance@pole_exit"), (InputArgument) "pd_exit", (InputArgument) 3000.0, (InputArgument) -2.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) 0.0);
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) this.StripperPed, (InputArgument) this.Scene1, (InputArgument) "pd_exit", (InputArgument) Class1.LoadDict("mini@strip_club@pole_dance@pole_exit"), (InputArgument) 3000.0, (InputArgument) -2f, (InputArgument) -2f, (InputArgument) this.StripperPed.Rotation.Z, (InputArgument) 1148846080, (InputArgument) 0);
          }
          if (!this.HasGottenUp)
          {
            string dict = "anim@amb@office@seating@male@var_a@base@";
            Class1.LoadDict(dict);
            Class1.LoadDict(dict);
            Script.Wait(4000);
            this.Scene1 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) (Game.Player.Character.Position.Z - 0.6f), (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (Game.Player.Character.Rotation.Z - 180f), (InputArgument) 2);
            Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) Class1.LoadDict(dict), (InputArgument) "exit", (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
            Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene1, (InputArgument) Function.Call<int>(Hash._0xE4A310B1D7FA73CC, (InputArgument) this.Scene1));
            Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene1, (InputArgument) "exit", (InputArgument) Class1.LoadDict(dict), (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
            Script.Wait(4000);
            Game.Player.Character.Task.ClearAll();
          }
        }
        this.IsWatching = false;
        Game.Player.Character.FreezePosition = false;
      }
      this.HasGottenUp = false;
    }

    public void GetUp()
    {
      Game.Player.Character.Weapons.Select(WeaponHash.Unarmed);
      this.Timer = 0.0f;
      int lastLoc = this.LastLoc;
      int yloc = this.YLOC;
      this.GetLocations(lastLoc);
      if (this.DanceType != 1)
        return;
      if ((Entity) this.StripperPed2 == (Entity) null)
      {
        string dict = "anim@amb@office@seating@male@var_a@base@";
        Class1.LoadDict(dict);
        Class1.LoadDict(dict);
        Script.Wait(1000);
        this.Scene2 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) (Game.Player.Character.Position.Z - 0.6f), (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) (Game.Player.Character.Rotation.Z - 180f), (InputArgument) 2);
        Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene2, (InputArgument) Class1.LoadDict(dict), (InputArgument) "exit", (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
        Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene2, (InputArgument) 0.0);
        Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene2, (InputArgument) "exit", (InputArgument) Class1.LoadDict(dict), (InputArgument) 16f, (InputArgument) -16f, (InputArgument) 0, (InputArgument) 1148846080);
        Script.Wait(4000);
        Game.Player.Character.Task.ClearAll();
      }
      this.HasGottenUp = true;
      Game.Player.Character.FreezePosition = false;
    }

    public void SitDown()
    {
      Game.Player.Character.Weapons.Select(WeaponHash.Unarmed);
      if (!((Entity) this.StripperPed2 == (Entity) null))
        return;
      Game.Player.Character.FreezePosition = true;
      Game.Player.Character.Position = this.SeatPos;
      Game.Player.Character.Heading = this.chairRot;
      string dict = "mini@strip_club@lap_dance@ld_girl_a_intro";
      Class1.LoadDict(dict);
      Class1.LoadDict(dict);
      this.Scene3 = Function.Call<int>(Hash._0x8C18E0F9080ADD73, (InputArgument) Game.Player.Character.Position.X, (InputArgument) Game.Player.Character.Position.Y, (InputArgument) Game.Player.Character.Position.Z, (InputArgument) 0.0, (InputArgument) 0.0, (InputArgument) Game.Player.Character.Rotation.Z, (InputArgument) 2);
      Function.Call(Hash._0x734292F4F0ABF6D0, (InputArgument) this.Scene3, (InputArgument) 0.0);
      Function.Call(Hash._0xEEA929141F699854, (InputArgument) Game.Player.Character, (InputArgument) this.Scene3, (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) "ld_girl_a_intro_m", (InputArgument) 3000.0, (InputArgument) -1.0, (InputArgument) 128, (InputArgument) 0, (InputArgument) 1148846080, (InputArgument) 0);
      Function.Call(Hash._0xC77720A12FE14A86, (InputArgument) Game.Player.Character, (InputArgument) this.Scene3, (InputArgument) "ld_girl_a_intro_m", (InputArgument) Class1.LoadDict("mini@strip_club@lap_dance@ld_girl_a_intro"), (InputArgument) 3000.0, (InputArgument) -1f, (InputArgument) -1f, (InputArgument) (this.StripperPed.Rotation.Z - 180f), (InputArgument) 1148846080, (InputArgument) 0);
      Script.Wait(100);
      this.PlayedPlayerAnim = true;
    }

    public void loadMenu(iFruitContact contact)
    {
      this.AddonPedHash.Clear();
      this.AddonPedName.Clear();
      this.Stripper.Clear();
      this.Stripper2.Clear();
      this.Stripper.Add((object) "Nikki");
      this.Stripper.Add((object) "Infernus");
      this.Stripper.Add((object) "Casisty");
      this.Stripper.Add((object) "Random");
      this.Stripper.Add((object) "Peach");
      this.Stripper.Add((object) "Cheetah");
      this.Stripper.Add((object) "Fufu");
      this.Stripper.Add((object) "Juliet");
      this.Stripper.Add((object) "Sapphire");
      this.Stripper.Add((object) "Sapphire (2)");
      this.Stripper.Add((object) "Casisty (2)");
      this.Stripper2.Add((object) "None");
      this.Stripper2.Add((object) "Nikki");
      this.Stripper2.Add((object) "Infernus");
      this.Stripper2.Add((object) "Casisty");
      this.Stripper2.Add((object) "Random");
      this.Stripper2.Add((object) "Peach");
      this.Stripper2.Add((object) "Cheetah");
      this.Stripper2.Add((object) "Fufu");
      this.Stripper2.Add((object) "Juliet");
      this.Stripper2.Add((object) "Sapphire");
      this.Stripper2.Add((object) "Sapphire (2)");
      this.Stripper2.Add((object) "Casisty (2)");
      foreach (string readAllLine in File.ReadAllLines("scripts\\Personal Hooker\\Personal Hooker.ini"))
      {
        if (readAllLine.Contains(","))
        {
          string[] strArray = readAllLine.Split(',');
          this.AddonPedHash.Add(strArray[0]);
          this.AddonPedName.Add(strArray[1]);
          this.Stripper.Add((object) strArray[1]);
          this.Stripper2.Add((object) strArray[1]);
        }
      }
      this.ifruit.Close();
      this.mainMenu.Visible = !this.mainMenu.Visible;
    }

    public void ShowUI()
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL");
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", (object) 0);
      scaleform.CallFunction("CREATE_CONTAINER");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 0, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 81, (InputArgument) 0), (object) "$50");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 1, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 82, (InputArgument) 0), (object) "$75");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 2, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 83, (InputArgument) 0), (object) "$100");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 3, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 84, (InputArgument) 0), (object) "Decline");
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", (object) -1);
      scaleform.Render2D();
    }

    public void ShowUI2()
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL");
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", (object) 0);
      scaleform.CallFunction("CREATE_CONTAINER");
      if (!this.HasGottenUp)
        scaleform.CallFunction("SET_DATA_SLOT", (object) 0, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 44, (InputArgument) 0), (object) "Get Up");
      if (this.HasGottenUp)
        scaleform.CallFunction("SET_DATA_SLOT", (object) 0, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 44, (InputArgument) 0), (object) "Watch Dance");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 1, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 51, (InputArgument) 0), (object) "Quit Dance");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 2, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 24, (InputArgument) 0), (object) "Flirt");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 3, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 34, (InputArgument) 0), (object) (" (" + this.DanceChar.ToString() + ")"));
      scaleform.CallFunction("SET_DATA_SLOT", (object) 4, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 35, (InputArgument) 0), (object) "Change Dance");
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", (object) -1);
      scaleform.Render2D();
    }

    public void ShowNonWatchingUI()
    {
      Convert.ToInt32(UIMenu.GetScreenResolutionMantainRatio().Width / 2f);
      Scaleform scaleform = new Scaleform(1);
      scaleform.Load("instructional_buttons");
      scaleform.CallFunction("CLEAR_ALL");
      scaleform.CallFunction("TOGGLE_MOUSE_BUTTONS", (object) 0);
      scaleform.CallFunction("CREATE_CONTAINER");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 0, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 51, (InputArgument) 0), (object) "Accept Dance");
      scaleform.CallFunction("SET_DATA_SLOT", (object) 3, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 34, (InputArgument) 0), (object) (" (" + this.DanceChar.ToString() + ")"));
      scaleform.CallFunction("SET_DATA_SLOT", (object) 4, (object) Function.Call<string>(Hash._0x0499D7B09FC9B407, (InputArgument) 2, (InputArgument) 35, (InputArgument) 0), (object) "Change Dance");
      scaleform.CallFunction("DRAW_INSTRUCTIONAL_BUTTONS", (object) -1);
      scaleform.Render2D();
    }

    public static string LoadDict(string dict)
    {
      while (true)
      {
        if (!Function.Call<bool>(Hash._0xD031A9162D01088C, (InputArgument) dict))
        {
          Function.Call(Hash._0xD3BD40951412FEF6, (InputArgument) dict);
          Script.Yield();
        }
        else
          break;
      }
      return dict;
    }

    private string getSpeechParam(int iParam0)
    {
      switch (iParam0)
      {
        case 0:
          return "SPEECH_PARAMS_STANDARD";
        case 1:
          return "SPEECH_PARAMS_ALLOW_REPEAT";
        case 2:
          return "SPEECH_PARAMS_BEAT";
        case 3:
          return "SPEECH_PARAMS_FORCE";
        case 4:
          return "SPEECH_PARAMS_FORCE_FRONTEND";
        case 5:
          return "SPEECH_PARAMS_FORCE_NO_REPEAT_FRONTEND";
        case 6:
          return "SPEECH_PARAMS_FORCE_NORMAL";
        case 7:
          return "SPEECH_PARAMS_FORCE_NORMAL_CLEAR";
        case 8:
          return "SPEECH_PARAMS_FORCE_NORMAL_CRITICAL";
        case 9:
          return "SPEECH_PARAMS_FORCE_SHOUTED";
        case 10:
          return "SPEECH_PARAMS_FORCE_SHOUTED_CLEAR";
        case 11:
          return "SPEECH_PARAMS_FORCE_SHOUTED_CRITICAL";
        case 12:
          return "SPEECH_PARAMS_FORCE_PRELOAD_ONLY";
        case 13:
          return "SPEECH_PARAMS_MEGAPHONE";
        case 14:
          return "SPEECH_PARAMS_HELI";
        case 15:
          return "SPEECH_PARAMS_FORCE_MEGAPHONE";
        case 16:
          return "SPEECH_PARAMS_FORCE_HELI";
        case 17:
          return "SPEECH_PARAMS_INTERRUPT";
        case 18:
          return "SPEECH_PARAMS_INTERRUPT_SHOUTED";
        case 19:
          return "SPEECH_PARAMS_INTERRUPT_SHOUTED_CLEAR";
        case 20:
          return "SPEECH_PARAMS_INTERRUPT_SHOUTED_CRITICAL";
        case 21:
          return "SPEECH_PARAMS_INTERRUPT_NO_FORCE";
        case 22:
          return "SPEECH_PARAMS_INTERRUPT_FRONTEND";
        case 23:
          return "SPEECH_PARAMS_INTERRUPT_NO_FORCE_FRONTEND";
        case 24:
          return "SPEECH_PARAMS_ADD_BLIP";
        case 25:
          return "SPEECH_PARAMS_ADD_BLIP_ALLOW_REPEAT";
        case 26:
          return "SPEECH_PARAMS_ADD_BLIP_FORCE";
        case 27:
          return "SPEECH_PARAMS_ADD_BLIP_SHOUTED";
        case 28:
          return "SPEECH_PARAMS_ADD_BLIP_SHOUTED_FORCE";
        case 29:
          return "SPEECH_PARAMS_ADD_BLIP_INTERRUPT";
        case 30:
          return "SPEECH_PARAMS_ADD_BLIP_INTERRUPT_FORCE";
        case 31:
          return "SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED";
        case 32:
          return "SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED_CLEAR";
        case 33:
          return "SPEECH_PARAMS_FORCE_PRELOAD_ONLY_SHOUTED_CRITICAL";
        case 34:
          return "SPEECH_PARAMS_SHOUTED";
        case 35:
          return "SPEECH_PARAMS_SHOUTED_CLEAR";
        case 36:
          return "SPEECH_PARAMS_SHOUTED_CRITICAL";
        default:
          return "";
      }
    }

    public void OnKeyDown()
    {
      if (!Game.IsControlJustPressed(2, GTA.Control.Cover) || !Game.IsControlPressed(2, GTA.Control.Reload))
        ;
      if (!Game.IsControlJustPressed(2, GTA.Control.VehicleDuck) || !Game.IsControlPressed(2, GTA.Control.Reload))
        ;
      if (!Game.IsControlJustPressed(2, GTA.Control.VehicleDuck) || !Game.IsControlPressed(2, GTA.Control.ThrowGrenade))
        ;
      if (!Game.IsControlJustPressed(2, GTA.Control.VehicleDuck) || !Game.IsControlPressed(2, GTA.Control.Context))
        ;
      if (!Game.IsControlJustPressed(2, GTA.Control.VehicleDuck) || !Game.IsControlPressed(2, GTA.Control.Cover))
        ;
      if (Game.IsControlJustPressed(2, GTA.Control.VehicleDuck) && Game.IsControlPressed(2, GTA.Control.Sprint))
        Function.Call(Hash._0xB6C49F8A5E295A5D, (InputArgument) this.Scene1, (InputArgument) 0.0f);
      if (!Game.IsControlJustPressed(2, GTA.Control.VehicleDuck) || Game.IsControlPressed(2, GTA.Control.Sprint))
        return;
      Function.Call(Hash._0xB6C49F8A5E295A5D, (InputArgument) this.Scene1, (InputArgument) 1f);
    }

    public enum Nodetype
    {
      AnyRoad,
      Road,
      Offroad,
      Water,
    }
  }
}
