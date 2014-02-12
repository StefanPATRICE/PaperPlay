using UnityEngine;
using System.Collections;

public class TraitementImage : MonoBehaviour {


	public Texture2D process(Texture2D texture) {

        Texture2D textureCible = new Texture2D(texture.width,texture.height);

        var cols = texture.GetPixels(0);
        for( var i = 0; i < cols.Length; ++i ) {
            //Debug.Log(1);
            //cols[i] = Color.Lerp( cols[i], colors[mip], 0.33 );
            if((cols[i].a + cols[i].b + cols[i].r) > 2)
                cols[i] = Color.white;
            else
                cols[i] = Color.black;

            //cols[i] = Color.Lerp( cols[i], Color.red, 0.5 );
            //cols[i] = new Color(Random.value,Random.value,Random.value);
        }
        /*
        for( i = 0; i < cols.Length; ++i ) {
            if(
            cols[i] != cols[topFrom(i)] ||
            cols[i] != cols[bottomFrom(i)] ||
            cols[i] != cols[leftFrom(i)] ||
            cols[i] != cols[rightFrom(i)])
                cols[i] = Color.red;
        }
        */
        textureCible.SetPixels(cols,0);
        textureCible.Apply();

        return textureCible;
	}
}
