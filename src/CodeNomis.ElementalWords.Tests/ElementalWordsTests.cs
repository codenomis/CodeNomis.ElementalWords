namespace CodeNomis.ElementalWords.Tests;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class ElementalWordsTests
{
    private readonly string[][] snackExpectedResult = new string[0][];

    [TestMethod()]
    public void ElementalForms_Word_SNACK_Test()
    {
        // Arrange
        string word = "snack";
        int count = 3;
        string[][] expected = new string[3][]; 
        expected[0] = ["Sulfur (S)", "Nitrogen (N)", "Actinium (Ac)", "Potassium (K)"];
        expected[1] = ["Sulfur (S)", "Sodium (Na)", "Carbon (C)", "Potassium (K)"];
        expected[2] = ["Tin (Sn)", "Actinium (Ac)", "Potassium (K)"];

        // Execute
        ElementalWords.ElementalForms(word);

        // Evaluate
        ElementalWords.Results.Should().HaveCount(count);
        ElementalWords.Results.Should().BeEquivalentTo(expected);
    }

    [TestMethod()]
    public void ElementalForms_Word_BEACH_Test()
    {
        // Arrange
        string word = "beach";
        int count = 1;
        string[][] expected = new string[1][];
        expected[0] = ["Beryllium (Be)", "Actinium (Ac)", "Hydrogen (H)"];

        // Execute
        ElementalWords.ElementalForms(word);

        // Evaluate
        ElementalWords.Results.Should().HaveCount(count);
        ElementalWords.Results.Should().BeEquivalentTo(expected);
    }

    [TestMethod()]
    public void ElementalForms_Word_YES_Test()
    {
        // Arrange
        string word = "yes";
        int count = 1;
        string[][] expected = new string[1][];
        expected[0] = ["Yttrium (Y)", "Einsteinium (Es)"];

        // Execute
        ElementalWords.ElementalForms(word);

        // Evaluate
        ElementalWords.Results.Should().HaveCount(count);
        ElementalWords.Results.Should().BeEquivalentTo(expected);
    }

//    internal static readonly Dictionary<string, string> Elements = new()
//{
//{ "H", "Hydrogen" }, { "He", "Helium" }, { "Li", "Lithium" }, { "Be", "Beryllium" }, { "B", "Boron" },    { "C", "Carbon" }, { "N", "Nitrogen" }, { "O", "Oxygen" }, { "F", "Fluorine" }, { "Ne", "Neon" },    { "Na", "Sodium" }, { "Mg", "Magnesium" }, { "Al", "Aluminum" }, { "Si", "Silicon" }, { "P", "Phosphorus" },    { "S", "Sulfur" }, { "Cl", "Chlorine" }, { "Ar", "Argon" }, { "K", "Potassium" }, { "Ca", "Calcium" },    { "Sc", "Scandium" }, { "Ti", "Titanium" }, { "V", "Vanadium" }, { "Cr", "Chromium" }, { "Mn", "Manganese" },    { "Fe", "Iron" }, { "Co", "Cobalt" }, { "Ni", "Nickel" }, { "Cu", "Copper" }, { "Zn", "Zinc" },    { "Ga", "Gallium" }, { "Ge", "Germanium" }, { "As", "Arsenic" }, { "Se", "Selenium" }, { "Br", "Bromine" },    { "Kr", "Krypton" }, { "Rb", "Rubidium" }, { "Sr", "Strontium" }, { "Y", "Yttrium" }, { "Zr", "Zirconium" },    { "Nb", "Niobium" }, { "Mo", "Molybdenum" }, { "Tc", "Technetium" }, { "Ru", "Ruthenium" }, { "Rh", "Rhodium" },    { "Pd", "Palladium" }, { "Ag", "Silver" }, { "Cd", "Cadmium" }, { "In", "Indium" }, { "Sn", "Tin" },    { "Sb", "Antimony" }, { "Te", "Tellurium" }, { "I", "Iodine" }, { "Xe", "Xenon" }, { "Cs", "Cesium" },    { "Ba", "Barium" }, { "La", "Lanthanum" }, { "Ce", "Cerium" }, { "Pr", "Praseodymium" }, { "Nd", "Neodymium" },    { "Pm", "Promethium" }, { "Sm", "Samarium" }, { "Eu", "Europium" }, { "Gd", "Gadolinium" }, { "Tb", "Terbium" },    { "Dy", "Dysprosium" }, { "Ho", "Holmium" }, { "Er", "Erbium" }, { "Tm", "Thulium" }, { "Yb", "Ytterbium" },    { "Lu", "Lutetium" }, { "Hf", "Hafnium" }, { "Ta", "Tantalum" }, { "W", "Tungsten" }, { "Re", "Rhenium" },    { "Os", "Osmium" }, { "Ir", "Iridium" }, { "Pt", "Platinum" }, { "Au", "Gold" }, { "Hg", "Mercury" },    { "Tl", "Thallium" }, { "Pb", "Lead" }, { "Bi", "Bismuth" }, { "Po", "Polonium" }, { "At", "Astatine" },    { "Rn", "Radon" }, { "Fr", "Francium" }, { "Ra", "Radium" }, { "Ac", "Actinium" }, { "Th", "Thorium" },    { "Pa", "Protactinium" }, { "U", "Uranium" }, { "Np", "Neptunium" }, { "Pu", "Plutonium" },    { "Am", "Americium" },    { "Cm", "Curium" }, { "Bk", "Berkelium" }, { "Cf", "Californium" }, { "Es", "Einsteinium" },    { "Fm", "Fermium" },    { "Md", "Mendelevium" }, { "No", "Nobelium" }, { "Lr", "Lawrencium" }, { "Rf", "Rutherfordium" },    { "Db", "Dubnium" },    { "Sg", "Seaborgium" }, { "Bh", "Bohrium" }, { "Hs", "Hassium" }, { "Mt", "Meitnerium" },    { "Ds", "Darmstadtium" },    { "Rg", "Roentgenium" }, { "Cn", "Copernicium" }, { "Nh", "Nihonium" }, { "Fl", "Flerovium" },    { "Mc", "Moscovium" },    { "Lv", "Livermorium" }, { "Ts", "Tennessine" }, { "Og", "Oganesson" }
//};
}