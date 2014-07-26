using Xunit;

namespace PluralizationServices.Tests.Rules.RuleEndedInL
{
    [Trait("Regras especiais terminando em l", "Plural e singular")]
    public class SpecialRuleEndedInL
    {
        private readonly PortuguesePluralizationService _service;

        public SpecialRuleEndedInL()
        {
            _service = new PortuguesePluralizationService();
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em al")]
        public void PLuralDeSubstantivoTerminadoEmAl() 
        {
            var plural = _service.Pluralize("funeral");

            Assert.Equal("funerais", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em al exce��o mal")]
        public void PLuralDeSubstantivoTerminadoEmAlExceptionMal() 
        {
            var plural = _service.Pluralize("mal");

            Assert.Equal("males", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em al exce��o real")]
        public void PLuralDeSubstantivoTerminadoEmAlExceptionReal() 
        {
            var plural = _service.Pluralize("real");

            Assert.Equal("r�is", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em el")]
        public void PLuralDeSubstantivoTerminadoEmEl() 
        {
            var plural = _service.Pluralize("pastel");

            Assert.Equal("past�is", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em il")]
        public void PLuralDeSubstantivoTerminadoEmIl() 
        {
            var plural = _service.Pluralize("canil");

            Assert.Equal("canis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em il �tono")]
        public void PLuralDeSubstantivoTerminadoEmIlAtono() 
        {
            var plural = _service.Pluralize("f�ssil");

            Assert.Equal("f�sseis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ol")]
        public void PLuralDeSubstantivoTerminadoEmOl() 
        {
            var plural = _service.Pluralize("farol");

            Assert.Equal("far�is", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ul")]
        public void PLuralDeSubstantivoTerminadoEmUl() 
        {
            var plural = _service.Pluralize("Raul");

            Assert.Equal("Rauis", plural);
        }

        [Fact(DisplayName = "Plural de um substantivo terminando em ul exce��o c�nsul")]
        public void PLuralDeSubstantivoTerminadoEmUlExceptionConsul() 
        {
            var plural = _service.Pluralize("c�nsul");

            Assert.Equal("c�nsules", plural);
        }
    }
}