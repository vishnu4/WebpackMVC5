using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebpackMVC5App.Models
{
    public enum NFPATypeEnum {
        Flammability,
        Health,
        Reactivity,
        Special
    }

    public class NFPAModel
    {

        internal const string specOX = "This denotes an oxidizer, a chemical which can greatly increase the rate of combustion/fire. ";
        internal const string specW = "Unusual reactivity with water. This indicates a potential hazard using water to fight a fire involving this material. ";
        internal const string specACID = "This indicates that the material is an acid, a corrosive material that has a pH lower than 7.0 ";
        internal const string specALK = "This denotes an alkaline material, also called a base. These caustic materials have a pH greater than 7.0 ";
        internal const string specCOR = "This denotes a material that is corrosive (it could be either an acid or a base). ";
        internal const string specSA = "This denotes gases which are simple asphyxiants. The only gases for which this symbol is permitted are nitrogen, helium, neon, argon, krypton, and xenon. The use of this hazard symbol is optional.";
        internal const string specSkull = "The skull and crossbones is used to denote a poison or highly toxic material. See also: CHIP Danger symbols.";
        internal const string specRad = "The international symbol for radioactivity is used to denote radioactive hazards; radioactive materials are extremely hazardous when inhaled.";
        internal const string specExp = "Indicates an explosive material. This symbol is somewhat redundant because explosives are easily recognized by their Instability Rating.";

        internal const string react4 = "Readily capable of detonation or of explosive decomposition or reaction at normal temperatures and pressures. ";
        internal const string react3 = "Capable of detonation or explosive reaction, but requires a strong initiating source or must be heated under confinement before initiation, or reacts explosively with water. ";
        internal const string react2 = "Normally unstable and readily undergo violent decomposition but do not detonate. Also: may react violently with water or may form potentially explosive mixtures with water. ";
        internal const string react1 = "Normally stable, but can become unstable at elevated temperatures and pressures or may react with water with some release of energy, but not violently. ";
        internal const string react0 = "Normally stable, even under fire exposure conditions, and are not reactive with water. ";

        internal const string flam4 = "Will rapidly or completely vaporize at normal pressure and temperature, or is readily dispersed in air and will burn readily. ";
        internal const string flam3 = "Liquids and solids that can be ignited under almost all ambient conditions. ";
        internal const string flam2 = "Must be moderately heated or exposed to relatively high temperature before ignition can occur. ";
        internal const string flam1 = "Must be preheated before ignition can occur. ";
        internal const string flam0 = "Materials that will not burn. ";

        internal const string health4 = "Very short exposure could cause death or serious residual injury even though prompt medical attention was given. ";
        internal const string health3 = "Short exposure could cause serious temporary or residual injury even though prompt medical attention was given. ";
        internal const string health2 = "Intense or continued exposure could cause temporary incapacitation or possible residual injury unless prompt medical attention is given. ";
        internal const string health1 = "Exposure could cause irritation but only minor residual injury even if no treatment is given. ";
        internal const string health0 = "Exposure under fire conditions would offer no hazard beyond that of ordinary combustible materials. ";

        public int ID { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public NFPATypeEnum NFPAType { get; set; }

        public string Name { get; set; }
    }
}