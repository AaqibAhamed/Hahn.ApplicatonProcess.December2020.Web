import { Aurelia, PLATFORM } from 'aurelia-framework';
import { Router, RouterConfiguration } from 'aurelia-router';

export class App {
     router: Router | undefined;

    configureRouter(config: RouterConfiguration, router: Router) {
        config.title = 'Hahn.ApplicatonProcess.December2020.Web';
        config.map([{
            route: ['', 'home'],
            name: 'home',
            settings: { icon: 'home' },
            moduleId: PLATFORM.moduleName('../home/home'),
            nav: true,
            title: 'Home'
        }, {
            route: 'form',
            name: 'form',
                settings: { icon: 'th-list' },
            moduleId: PLATFORM.moduleName('../form/form'),
            nav: true,
            title: 'Form'
        }, {
            route: 'counter',
            name: 'counter',
            settings: { icon: 'education' },
            moduleId: PLATFORM.moduleName('../counter/counter'),
            nav: true,
            title: 'Counter'
        }, {
            route: 'fetch-data',
            name: 'fetchdata',
            settings: { icon: 'th-list' },
            moduleId: PLATFORM.moduleName('../fetchdata/fetchdata'),
            nav: true,
            title: 'Fetch data'
        }]);

        this.router = router;
    }
}
