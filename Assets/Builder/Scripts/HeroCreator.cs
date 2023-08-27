using UnityEngine;

namespace BuilderPattern
{
    public class HeroCreator : MonoBehaviour
    {
        [SerializeField] private Weapon[] _possibleWeapon;
        [SerializeField] private Skin[] _possibleSkin;
        [SerializeField] private Helmet[] _possibleHelmet;
        [SerializeField] private ChessPlate[] _possibleChess;
        [SerializeField] private Boots[] _possibleBoots;
        [SerializeField] private Leggins[] _possibleLeggs;

        private readonly HeroBuilder _heroBuilder = new HeroBuilder();

        public void SelectWeapon(int weaponIndex)
        {
            _heroBuilder.WithWeapon(_possibleWeapon[weaponIndex]);
        }
        public void SelectSkin(int skinIndex)
        {
            _heroBuilder.WithSkin(_possibleSkin[skinIndex]);
        }
        public void SelectH(int HIndex)
        {
            _heroBuilder.WithHelmet(_possibleHelmet[HIndex]);
        }
        public void SelectChess(int chessIndex)
        {
            _heroBuilder.WithChessPlate(_possibleChess[chessIndex]);
        }
        public void SelectLeggs(int leggsIndex)
        {
            _heroBuilder.WithLeggins(_possibleLeggs[leggsIndex]);
        }
        public void SelectBoots(int bootsIndex)
        {
            _heroBuilder.WithBoots(_possibleBoots[bootsIndex]);
        }

        public void CreateHero()
        {
            _heroBuilder.Build();
        }
    }
}
