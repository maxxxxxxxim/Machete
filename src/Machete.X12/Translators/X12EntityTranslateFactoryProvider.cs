﻿namespace Machete.X12.Translators
{
    using Machete.Translators;
    using TranslateConfiguration;


    public class X12EntityTranslateFactoryProvider<TSchema> :
        IEntityTranslateFactoryProvider<TSchema>
        where TSchema : X12Entity
    {
        public IEntityTranslatorFactory<TInput, TSchema> GetTranslateFactory<TResult, TInput>(IEntityTranslateSpecification<TResult, TInput, TSchema> specification)
            where TResult : TSchema
            where TInput : TSchema
        {
            return new X12EntityTranslatorFactory<TResult, TInput, TSchema>(specification);
        }
    }
}