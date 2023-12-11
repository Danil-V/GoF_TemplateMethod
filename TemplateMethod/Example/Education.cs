namespace TemplateMethod.Example
{
    public abstract class Learning {
        public abstract void Learn();
    }

    public abstract class Education : Learning {
        // Cкрываем алгоритм от изменения в классах наследниках с помощью sealed
        public sealed override void Learn() { 
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams() {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();
    }

    
}
