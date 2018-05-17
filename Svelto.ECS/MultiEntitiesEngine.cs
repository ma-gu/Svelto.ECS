namespace Svelto.ECS
{
    public abstract class MultiEntitiesEngine<T, U> : SingleEntitiesEngine<T>, IHandleEntityStructEngine<U>
        where U : struct, IEntityData where T : struct, IEntityData
    {
        public void AddInternal(ref U entityView)
        { Add(ref entityView); }
        public void RemoveInternal(ref U entityView)
        { Remove(ref entityView); }
        
        protected abstract void Add(ref U    entityView);
        protected abstract void Remove(ref U entityView);
    }
    
    public abstract class MultiEntitiesEngine<T, U, V> : MultiEntitiesEngine<T, U>, IHandleEntityStructEngine<V>
        where V :  struct, IEntityData where U :  struct, IEntityData where T :  struct, IEntityData
    {
        public void AddInternal(ref V entityView)
        { Add(ref entityView); }
        public void RemoveInternal(ref V entityView)
        { Remove(ref entityView); }
        
        protected abstract void Add(ref V    entityView);
        protected abstract void Remove(ref V entityView);
    }

    /// <summary>
    ///     Please do not add more MultiEntityViewsEngine
    ///     if you use more than 4 nodes, your engine has
    ///     already too many responsabilities.
    /// </summary>
    public abstract class MultiEntitiesEngine<T, U, V, W> : MultiEntitiesEngine<T, U, V>, IHandleEntityStructEngine<W>
        where W :  struct, IEntityData where V :  struct, IEntityData where U :  struct, IEntityData where T : struct, IEntityData
    {
        public void AddInternal(ref W entityView)
        { Add(ref entityView); }
        public void RemoveInternal(ref W entityView)
        { Remove(ref entityView); }
        
        protected abstract void Add(ref W    entityView);
        protected abstract void Remove(ref W entityView);
    }
}