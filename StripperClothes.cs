using GTA;
using GTA.Native;

namespace Personal_Hooker
{
  public class StripperClothes
  {
    public int Component { get; set; }

    public int Texture { get; set; }

    public int Palette { get; set; }

    public StripperClothes(int C, int T, int P)
    {
      this.Component = C;
      this.Texture = T;
      this.Palette = P;
    }

    public int GTexture(int i, Ped PresetPed) => Function.Call<int>(Hash._0x04A355E041E004E6, (InputArgument) PresetPed, (InputArgument) i);

    public int GPalette(int i, Ped PresetPed) => Function.Call<int>(Hash._0xE3DD5F2A84B42281, (InputArgument) PresetPed, (InputArgument) i);
  }
}
