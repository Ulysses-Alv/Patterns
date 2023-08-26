using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class HeroBuilder
{
    private Hero hero;
    private Weapon weapon;
    private Helmet helmet;
    private ChessPlate chess;
    private Leggins leggins;
    private Boots boots;
    private Skin skin;
    private Vector3 _position;
    private Quaternion _rotation;

    public HeroBuilder()
    {
        // Default values
        _rotation = Quaternion.identity;
        _position = Vector3.zero;
    }

    public HeroBuilder WithPosition(Vector3 position)
    {
        _position = position;
        return this;
    }

    public HeroBuilder WithRotation(Quaternion rotation)
    {
        _rotation = rotation;
        return this;
    }

    public HeroBuilder WithSkin(Skin skin)
    {
        this.skin = skin;
        return this;
    }
    public HeroBuilder WithHelmet(Helmet helmet)
    {
        this.helmet = helmet;
        return this;
    }
    public HeroBuilder WithChessPlate(ChessPlate chess)
    {
        this.chess = chess;
        return this;
    }
    public HeroBuilder WithLeggins(Leggins leggins)
    {
        this.leggins = leggins;
        return this;
    }
    public HeroBuilder WithBoots(Boots boots)
    {
        this.boots = boots;
        return this;
    }
    public HeroBuilder WithWeapon(Weapon weapon)
    {
        this.weapon = weapon;
        return this;
    }



    public HeroBuilder FromHeroPrefab(Hero hero)
    {
        this.hero = hero;
        return this;
    }

    public Hero Build()
    {
        var hero = Object.Instantiate(this.hero, _position, _rotation);

        hero.SetComponents(skin, helmet, weapon, chess, leggins, boots);

        return hero;
    }


}