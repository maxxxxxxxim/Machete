﻿namespace Machete.TranslateConfiguration.Specifications
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Configuration;
    using Translators.PropertyTranslaters;


    public class TranslateEntityValueUsingSpecification<TResult, TInput, TTranslate, TEntity, TSchema> :
        PropertyTranslateSpecification<TResult, Value<TEntity>, TInput, TSchema>
        where TEntity : TSchema
        where TSchema : Entity
        where TTranslate : IEntityTranslateSpecification<TEntity, TEntity, TSchema>
        where TResult : TSchema
        where TInput : TSchema
    {
        readonly Func<IEntityTranslateSpecification<TEntity, TEntity, TSchema>> _specification;

        public TranslateEntityValueUsingSpecification(Expression<Func<TResult, Value<TEntity>>> propertyExpression,
            Func<IEntityTranslateSpecification<TEntity, TEntity, TSchema>> specification)
            : base(propertyExpression)
        {
            _specification = specification;
        }

        protected override IEnumerable<ValidateResult> Validate()
        {
            yield break;
        }

        public override IEnumerable<Type> GetReferencedTranslateTypes()
        {
            yield return typeof(TTranslate);
        }

        public override void Apply(IEntityTranslateBuilder<TResult, TInput, TSchema> builder)
        {
            IEntityTranslator<TEntity, TSchema> entityTranslator = builder.GetEntityTranslator(typeof(TTranslate), _specification);

            var translator = new TranslateEntityValuePropertyTranslator<TResult, TEntity, TInput, TSchema>(builder.ImplementationType, ResultPropertyInfo, InputPropertyInfo,
                entityTranslator);

            builder.Add(ResultPropertyInfo.Name, translator);
        }
    }
}