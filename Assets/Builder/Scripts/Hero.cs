using UnityEngine;

namespace BuilderPattern
{
    public class Hero : MonoBehaviour
    {
        Skin skin;

        Weapon weapon;

        Helmet helmet;
        ChessPlate chess;
        Leggins leggins;
        Boots boots;

        public void SetComponents(Skin skin, Helmet helmet, Weapon weapon, ChessPlate chessPlate, Leggins leggins, Boots boots)
        {
            this.skin = skin;
            this.weapon = weapon;
            this.helmet = helmet;
            this.chess = chessPlate;
            this.leggins = leggins;
            this.boots = boots;
        }
    }
}
