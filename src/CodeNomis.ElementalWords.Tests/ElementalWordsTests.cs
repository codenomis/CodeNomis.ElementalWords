namespace CodeNomis.ElementalWords.Tests;

using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass()]
public class ElementalWordsTests
{
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

}