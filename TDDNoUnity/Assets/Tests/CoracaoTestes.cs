using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class CoracaoTestes
    {
        public class TestesMetodoRecarga
        {
            private Image img;
            private Coracao cor;

            [SetUp]
            public void Config()
            {
                img = new GameObject().AddComponent<Image>();
                cor = new Coracao(img);
            }

            [Test]
            public void imagemPreenchimento0Recarregamento0()
            {
                img.fillAmount = 0;
                cor.Recarregar(0);

                Assert.AreEqual(0, img.fillAmount);
            }

            [Test]
            public void imagemPreenchimento0Recarregamento1()
            {
                img.fillAmount = 0;
                cor.Recarregar(1);

                Assert.AreEqual(0.25f, img.fillAmount);
            }

            [Test]
            public void imagemPreenchimento025Recarregamento1()
            {
                img.fillAmount = 0.25f;
                cor.Recarregar(1);

                Assert.AreEqual(0.5f, img.fillAmount);
            }

            [Test]
            public void imagemPreenchimento1Recarregamento1()
            {
                img.fillAmount = 1;
                cor.Recarregar(1);

                Assert.AreEqual(1, img.fillAmount);
            }
        }

        public class TestesMetodoDescarga
        {
            private Image img;
            private Coracao cor;

            [SetUp]
            public void Config()
            {
                img = new GameObject().AddComponent<Image>();
                cor = new Coracao(img);
            }

            [Test]
            public void imagemPreenchimento1Descarregamento1()
            {
                img.fillAmount = 1.0f;
                cor.Descarregar(1);

                Assert.AreEqual(0.75f, img.fillAmount);
            }

            [Test]
            public void imagemPreenchimento0Descarregamento1()
            {
                img.fillAmount = 0.0f;
                cor.Descarregar(1);

                Assert.AreEqual(0.0f, img.fillAmount);
            }

            [Test]
            public void lancaExcecaoNumeroNegativo()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => cor.Descarregar(-1));
            }
        }


    }
}

