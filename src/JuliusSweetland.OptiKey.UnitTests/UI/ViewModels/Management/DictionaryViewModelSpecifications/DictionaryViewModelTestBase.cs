﻿using OptiKey.Services;
using OptiKey.UI.ViewModels.Management;
using Moq;

namespace OptiKey.UnitTests.UI.ViewModels.Management.DictionaryViewModelSpecifications
{
    public abstract class DictionaryViewModelTestBase : TestBase
    {
        protected DictionaryViewModel DictionaryViewModel { get; set; }
        protected Mock<IDictionaryService> DictionaryService { get; private set; }

        protected virtual bool ShouldConstruct { get { return true; } }

        protected override void Arrange()
        {
            DictionaryService = new Mock<IDictionaryService>();

            if (ShouldConstruct)
            {
                DictionaryViewModel = new DictionaryViewModel(DictionaryService.Object);
            }
        }
    }
}