using UnityEngine;
using System.Collections;

public class TraitementImage : MonoBehaviour {

    public static int convert2Dto1D(int x, int y, int width, int height) {
        return x * width + y;
    }
    public static int topFrom(int i, int width, int height) {
        //Debug.Log(i);
        //Debug.Log('-');
        //Debug.Log(i);
        //Debug.Log(width);
        //Debug.Log(i - width);
        //Debug.Log(i - width > 0 ? i - width : i);
        return i - width > 0 ? i - width : i;
        //return i;
    }
    public static int bottomFrom(int i, int width, int height) {
        return i + width < width * height  ? i + width : i;
    }
    public static int leftFrom(int i, int width, int height) {
        return i - 1 > 0  ? i - 1 : i;
    }
    public static int rightFrom(int i, int width, int height) {
        return i + 1 < width * height ? i + 1 : i;
    }
    public static int safeFrom(int i, int width, int height) {
        return i;
    }


	public static Texture2D process(Texture2D texture) {
                           /*
	    Color couleur1 = new Color(0.2f, 0.3f ,0.1f);
	    Color couleur2 = new Color(0.2f, 0.1f ,0.3f);
	    int j = 5;
	    Debug.Log(new Color(
            (couleur1.a * (double) j + couleur2.a) / (double) (j + 1),
            (couleur1.b * (double) j + couleur2.b) / (double) (j + 1),
            (couleur1.r * (double) j + couleur2.r) / (double) (j + 1)
        ));
        */

        Texture2D textureCible = new Texture2D(texture.width,texture.height);

        Color minColor = Color.black;
        Color moyColor = Color.black;

        var cols = texture.GetPixels(0);
        for( var i = 0; i < cols.Length; ++i ) {
            //Debug.Log(1);
            //cols[i] = Color.Lerp( cols[i], colors[mip], 0.33 );
            moyColor = Color.Lerp(cols[i], moyColor, (float) ((float) (i - 1) / (float) i));
            if((cols[i].a + cols[i].b + cols[i].r) > (minColor.a + minColor.b + minColor.r))
                minColor = cols[i];
            if((cols[i].a + cols[i].b + cols[i].r) > 1.3f)
                cols[i] = Color.white;
            else
                cols[i] = Color.black;

            //cols[i] = Color.Lerp( cols[i], Color.red, 0.5 );
            //cols[i] = new Color(Random.value,Random.value,Random.value);
        }
        var cols2 = texture.GetPixels(0);
        for( var i = 0; i < cols.Length; ++i ) {
            if(
            cols[i] == Color.white &&
            cols[i] != cols[topFrom(i, texture.width, texture.height)] ||
            cols[i] != cols[leftFrom(i, texture.width, texture.height)] ||
            cols[i] != cols[rightFrom(i, texture.width, texture.height)] ||
            cols[i] != cols[bottomFrom(i, texture.width, texture.height)])
            /*
            (
            cols[i] != cols[topFrom(i, texture.width, texture.height)] ||
            cols[i] != cols[bottomFrom(i, texture.width, texture.height)] ||
            cols[i] != cols[leftFrom(i, texture.width, texture.height)] ||
            cols[i] != cols[rightFrom(i, texture.width, texture.height)])
            */
            {
                cols2[i] = Color.red;
            }
            else
            {
                if(cols[i] == Color.white)
                    cols2[i] = minColor;
                else
                    cols2[i] = moyColor;
            }
        }

        textureCible.SetPixels(cols2,0);
        textureCible.Apply();

        return textureCible;
	}
}
