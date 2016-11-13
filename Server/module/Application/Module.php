<?php

/**
 * Zend Framework (http://framework.zend.com/)
 *
 * @link      http://github.com/zendframework/ZendSkeletonApplication for the canonical source repository
 * @copyright Copyright (c) 2005-2012 Zend Technologies USA Inc. (http://www.zend.com)
 * @license   http://framework.zend.com/license/new-bsd New BSD License
 */

namespace Application;

use Zend\Mvc\ModuleRouteListener;
use Zend\Mvc\MvcEvent;
use Application\Services\ServiceLocatorFactory;

class Module
{

    public function onBootstrap(MvcEvent $e)
    {
        ServiceLocatorFactory::setInstance($e->getApplication()->getServiceManager());

        $application = $e->getApplication();
        $application->getServiceManager()->get('translator');
        $eventManager = $application->getEventManager();
        $moduleRouteListener = new ModuleRouteListener();
        $moduleRouteListener->attach($eventManager);
    }

    public function getConfig()
    {
        return include __DIR__ . '/config/module.config.php';
    }

    public function getAutoloaderConfig()
    {
        return array(
            'Zend\Loader\StandardAutoloader' => array(
                'namespaces' => array(
                    __NAMESPACE__ => __DIR__ . '/src/' . __NAMESPACE__,
                ),
            ),
        );
    }

//    public function getViewHelperConfig()
//    {
//        return [
//            'factories' => [
//                // This will overwrite the native navigation helper
//                'navigation' => function(HelperPluginManager $pm) {
//                    $navigation = $pm->get('Zend\View\Helper\Navigation');
//                    return $navigation;
//                }
//            ]
//        ];
//    }
}
